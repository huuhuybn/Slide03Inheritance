using Unity.Cinemachine;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public CinemachineCamera camera;
    CinemachineBasicMultiChannelPerlin noise;
    private float shakeTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        noise = camera.GetComponentInChildren<CinemachineBasicMultiChannelPerlin>();
    }
    public void Shake(float intensity, float duration)
    {
        noise.AmplitudeGain = intensity;
        shakeTimer = duration;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Shake(0.6f,0.5f);
        }
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer <= 0)
            {
                noise.AmplitudeGain = 0;
            }
        }
    }
}
