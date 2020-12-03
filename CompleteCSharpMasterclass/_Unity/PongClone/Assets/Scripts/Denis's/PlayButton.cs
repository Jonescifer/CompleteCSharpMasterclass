﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame(int sceneID)
    {
        Debug.Log("Play button was pressed");
        SceneManager.LoadScene(sceneID);
    }
}
