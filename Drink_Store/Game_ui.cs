using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_ui : MonoBehaviour
{
public void Start_Game()
{
    SceneManager.LoadSceneAsync(1);
}
}
