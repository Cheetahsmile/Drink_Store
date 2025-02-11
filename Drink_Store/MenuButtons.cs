using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{

    public GameObject InGameMenuScreen;
    public Rigidbody2D playerRigidbody; // Reference to the menu GameObject

    public void OnStartButtonClicked()
    {
        Debug.Log("Game Start");
    }

    public bool isPaused = false;

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        InGameMenuScreen.SetActive(isPaused);
    }
    public void play(){
        isPaused = false; 

        // unpause here
        // public void OnStartButtonClicked()
        // {
        //     SceneManager.LoadScene("InGameMenuScreen");
        //     isPaused = false;
        // }
        
        //hide the menu
       InGameMenuScreen.SetActive(false);
    }
}
