using UnityEngine;
using System.Collections.Generic;

public class GroundAgent : MonoBehaviour
{
    public Transform[] waypoints;   // Waypoints para patrulla o idle
    public float speed = 3f;
    public float stopDistance = 1.5f; // Distancia para detenerse y curar

    private int currentIndex = 0;
    private Queue<Transform> targets = new Queue<Transform>();
    private Transform currentTarget;
    private bool isHealing = false;

    public void AddTarget(Transform target)
    {
        if (!targets.Contains(target))
        {
            targets.Enqueue(target);
            Debug.Log("GroundAgent recibió nuevo objetivo: " + target.name);
        }
    }

    void Update()
    {
        if (isHealing) return;

        // Prioridad: Objetivos de la cola
        if (currentTarget == null && targets.Count > 0)
        {
            currentTarget = targets.Dequeue();
        }

        if (currentTarget != null)
        {
            MoveTo(currentTarget.position);
            
            // Si llegamos al objetivo
            if (Vector3.Distance(transform.position, currentTarget.position) < stopDistance)
            {
                // Intentar curar
                PlantHealth plant = currentTarget.GetComponent<PlantHealth>();
                if (plant != null && plant.state == PlantState.Infected)
                {
                    plant.Cure();
                    Debug.Log("GroundAgent curando a: " + currentTarget.name);
                    isHealing = true;
                    Invoke("FinishHealing", 2f); // Simular tiempo de curación
                }
                else
                {
                    // Si ya no está infectada o no es planta, pasamos al siguiente
                    currentTarget = null;
                }
            }
        }
        else
        {
            // Comportamiento por defecto: Patrulla por waypoints
            Patrol();
        }
    }

    void FinishHealing()
    {
        isHealing = false;
        currentTarget = null; // Listo para el siguiente
    }

    void MoveTo(Vector3 destination)
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

        Vector3 direction = destination - transform.position;
        if (direction != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(direction);
    }

    void Patrol()
    {
        if (waypoints.Length == 0) return;

        Transform target = waypoints[currentIndex];
        MoveTo(target.position);

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            currentIndex = (currentIndex + 1) % waypoints.Length; // Loop
        }
    }
}
