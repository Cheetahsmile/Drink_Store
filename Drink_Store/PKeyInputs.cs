using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PKeyInputs : MonoBehaviour
{

    public GameObject InGameMenuScreen;
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
    public void InGameMenu()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P Key is Pressed.");
            if (InGameMenuScreen != null)
            {
                //Debug.Log();
            }
             InGameMenuScreen.SetActive(true);
        }
    }
}
