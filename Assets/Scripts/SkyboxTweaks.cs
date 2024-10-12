using UnityEngine;

public class SkyboxTweaks : MonoBehaviour
{
    public float SkyboxSpeed;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * SkyboxSpeed);
    }
}
