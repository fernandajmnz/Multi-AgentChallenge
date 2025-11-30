using UnityEngine;

public class ScanLightPulse : MonoBehaviour
{
    public Light scanLight;
    public float minIntensity = 5f;
    public float maxIntensity = 12f;
    public float speed = 2f;

    void Update()
    {
        if (scanLight != null)
        {
            scanLight.intensity = Mathf.Lerp(minIntensity, maxIntensity,
                (Mathf.Sin(Time.time * speed) + 1) / 2f);
        }
    }
}
