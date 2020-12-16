using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool gameStarted;
    
    public void GameStarted()
    {
        gameStarted = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameStarted();
        }
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }
}
