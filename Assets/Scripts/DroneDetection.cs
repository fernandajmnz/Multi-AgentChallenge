using UnityEngine;

public class DroneDetection : MonoBehaviour
{
    public float detectRadius = 3f;

    public GroundAgent groundAgent; // Asignar en inspector o buscar

    void Start()
    {
        if (groundAgent == null)
            groundAgent = FindObjectOfType<GroundAgent>();
    }

    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, detectRadius);

        foreach (var hit in hits)
        {
            PlantHealth plant = hit.GetComponentInParent<PlantHealth>();
            if (plant == null) continue;

            // 👉 Detectar infección oculta
            if (plant.state == PlantState.Healthy && plant.hasHiddenInfection)
            {
                plant.RevealInfection(); // Se vuelve roja
                Debug.Log("Dron detectó planta enferma: " + plant.name);

                if (groundAgent != null)
                {
                    groundAgent.AddTarget(plant.transform);
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectRadius);
    }
}
