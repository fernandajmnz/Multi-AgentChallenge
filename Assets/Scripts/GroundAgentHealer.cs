using UnityEngine;

public class GroundAgentHealer : MonoBehaviour
{
    public float healRadius = 2.5f;

    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, healRadius);

        foreach (var hit in hits)
        {
            PlantHealth plant = hit.GetComponentInParent<PlantHealth>();
            if (plant == null) continue;

            // Curar plantas infectadas
            if (plant.state == PlantState.Infected)
            {
                plant.Cure();
                Debug.Log("Planta curada por GroundAgent: " + plant.name);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, healRadius);
    }
}
