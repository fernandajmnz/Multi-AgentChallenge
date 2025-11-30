using UnityEngine;

public class DroneAgent : MonoBehaviour
{
    public Transform[] waypoints;   // Waypoints en orden EXACTO  
    public float speed = 3f;

    private int currentIndex = 0;
    private bool finished = false;

    void Update()
    {
        if (finished) return;  // ⛔ ya terminó

        Transform target = waypoints[currentIndex];
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Rotación hacia adelante (opcional)
        Vector3 direction = target.position - transform.position;
        if (direction != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(direction);

        // Si llegó al waypoint
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            currentIndex++;

            // ✔ Si ya recorrió TODOS los waypoints → SE DETIENE
            if (currentIndex >= waypoints.Length)
            {
                finished = true;
                Debug.Log("Ruta completada. GroundRobot detenido.");
            }
        }
    }
}
