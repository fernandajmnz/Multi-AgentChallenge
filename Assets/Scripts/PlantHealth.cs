using UnityEngine;
using System.Collections;   // necesario para corutinas

public enum PlantState {
    Healthy,   // Verde
    Detected,  // Amarillo
    Infected,  // Rojo
    Treated    // Azul
}

[DisallowMultipleComponent]
public class PlantHealth : MonoBehaviour
{
    [Header("Estado inicial")]
    public PlantState state = PlantState.Healthy;

    [Header("Colores por estado")]
    public Color healthyColor  = Color.green;
    public Color detectedColor = Color.yellow;
    public Color infectedColor = Color.red;
    public Color treatedColor  = Color.blue;

    [Header("Comportamiento al ser tratada")]
    [Tooltip("Tiempo que permanece azul antes de regresar a verde")]
    public float treatedRecoveryTime = 2f;
    public bool autoRecoverToHealthy = true;

    private Renderer[] renderers;
    private Coroutine recoveryRoutine;

    void Awake()
    {
        CacheRenderers();
        ApplyColor();
    }

    void CacheRenderers()
    {
        if (renderers == null || renderers.Length == 0)
        {
            renderers = GetComponentsInChildren<Renderer>();
        }
    }

    public void SetState(PlantState newState)
    {
        state = newState;
        ApplyColor();
    }

    // 🟦 Cuando el robot cura → azul
    public void Cure()
    {
        state = PlantState.Treated;
        ApplyColor();

        // Después de unos segundos vuelve a verde
        if (autoRecoverToHealthy)
        {
            if (recoveryRoutine != null)
                StopCoroutine(recoveryRoutine);

            recoveryRoutine = StartCoroutine(RecoverAfterDelay());
        }
    }

    // 🟩 Regresa a verde tras ser tratada
    IEnumerator RecoverAfterDelay()
    {
        yield return new WaitForSeconds(treatedRecoveryTime);

        state = PlantState.Healthy;
        ApplyColor();
        recoveryRoutine = null;
    }

    // 🟨 Dron detecta → amarilla, luego roja
    public void MarkDetectedThenInfect(float delay = 2f)
    {
        // Si ya está infectada o tratada NO la tocamos
        if (state == PlantState.Infected || state == PlantState.Treated)
            return;

        // Se vuelve amarilla
        SetState(PlantState.Detected);

        // Después de delay → infectada (roja)
        StartCoroutine(BecomeInfected(delay));
    }

    private IEnumerator BecomeInfected(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Si el robot la curó, no infectamos nada
        if (state == PlantState.Treated || state == PlantState.Healthy)
            yield break;

        // Se vuelve roja
        SetState(PlantState.Infected);
    }

    // 🎨 Aplica color a TODAS las partes del prefab
    void ApplyColor()
    {
        CacheRenderers();
        if (renderers == null || renderers.Length == 0)
            return;

        Color c;

        switch (state)
        {
            case PlantState.Detected: c = detectedColor; break;
            case PlantState.Infected: c = infectedColor; break;
            case PlantState.Treated:  c = treatedColor;  break;
            default:                  c = healthyColor;  break;
        }

        foreach (var r in renderers)
        {
            if (r != null && r.material != null)
                r.material.color = c;
        }
    }
}
