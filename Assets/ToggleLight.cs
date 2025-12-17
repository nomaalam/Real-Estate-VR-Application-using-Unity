using UnityEngine;

// We don't need UnityEngine.InputSystem anymore
public class ToggleLight : MonoBehaviour
{
    // This is the light we want to turn on/off
    public GameObject lightToToggle;

    // This is a new public function that any
    // button or event can call.
    public void ToggleTheLight()
    {
        if (lightToToggle != null)
        {
            lightToToggle.SetActive(!lightToToggle.activeSelf);
        }
    }
}