using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    // awake gets called when the game object is created in the scene for the first time
    void Awake(){
        Debug.Log("Awake function has beeen called");
    }
  // update function gets called everytime game object rerenders, which is 60 times per second. 
    void Update()
    {
        Debug.Log("Update function has been called");
    }
    // FixedUpdate is executed at a specific rate that can defined unlike the update function
    void FixedUpdate(){
        
    }
}
