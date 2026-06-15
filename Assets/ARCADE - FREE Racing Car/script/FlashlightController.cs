using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public Light spotLight;
    public KeyCode toggleKey = KeyCode.F;
    private bool isOn = true;

    void Start()
    {
        if (spotLight == null)
            spotLight = GetComponent<Light>();
        spotLight.enabled = isOn;
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            isOn = !isOn;
            spotLight.enabled = isOn;
        }
    }
}