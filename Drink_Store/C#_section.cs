using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csharp_script : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        string[] Welcome = { " welcome To my game", "My game is about a woman trying to escape a store with robots and ghost", "She has a robot companion and this woman's really good at fighting", "So watch out"};
        for (int i= 0; i<= Welcome.Length;i++)
        {
            Debug.Log(Welcome[i]);
            //Console.WriteLine(Welcome[i]);
        }
    }       
      
