using UnityEngine;

public class InfectRandomPlants : MonoBehaviour
{
    [Range(0f, 1f)]
    public float infectionRate = 0.2f;  // 20% de las plantas empiezan infectadas

    void Start()
    {
        PlantHealth[] plants = FindObjectsOfType<PlantHealth>();

        int infectedCount = 0;

        foreach (var plant in plants)
        {
            if (Random.value < infectionRate)
            {
                plant.SetState(PlantState.Infected);  // rojo
                infectedCount++;
            }
        }

        Debug.Log($"🌱 Infectadas al inicio: {infectedCount} / {plants.Length}");
    }
}
