using UnityEngine;

public class DroneDetection : MonoBehaviour
{
    public float detectRadius = 3f;

    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, detectRadius);

        foreach (var hit in hits)
        {
            PlantHealth plant = hit.GetComponentInParent<PlantHealth>();
            if (plant == null) continue;

            // 👉 SOLO detecta plantas que aún NO han sido detectadas ni infectadas
            if (plant.state == PlantState.Healthy)
            {
                plant.MarkDetectedThenInfect(2f);
                Debug.Log("Planta detectada por dron: " + plant.name);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectRadius);
    }
}
