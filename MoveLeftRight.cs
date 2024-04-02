using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Update is called  60 times per sec 
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 newPosition = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0f, 0f);

        transform.position = newPosition;
    } 

    void FixedUpdate(){
        








    }
}
