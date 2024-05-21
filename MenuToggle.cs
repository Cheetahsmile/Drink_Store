using UnityEngine;
using UnityEngine.UI;

public class MenuToggle : MonoBehaviour
{
    public GameObject inGameMenuScreen; // Reference to the menu GameObject

    // This function will be called when the button is clicked
    public void ToggleMenu()
    {
        // Check if the menu GameObject is active
        if (inGameMenuScreen.activeSelf)
        {
            // If active, deactivate it
            inGameMenuScreen.SetActive(false);
        }
        else
        {
            // If inactive, activate it
            inGameMenuScreen.SetActive(true);

           // isPaused = false;
            // pause game here

        }
    }
}
