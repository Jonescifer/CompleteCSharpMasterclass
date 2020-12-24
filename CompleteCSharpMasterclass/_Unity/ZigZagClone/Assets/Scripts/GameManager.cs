using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public bool gameStarted;
    public int score;
    public Text scoreText;
    public Text highScore;

    private void Awake()
    {
        highScore.text = "Best: " + GetHighScore().ToString();
    }

    

    private void StartGame()
    {
        gameStarted = true;
    }

    private void Update()
    {
        //if return was pressed start game.
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }

      
    }

    public static void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        Debug.Log($"the score is {score}");
        
        if (score > GetHighScore())
        {
            PlayerPrefs.SetInt("Highscore", score);
            highScore.text = "Best: " + GetHighScore().ToString();
            Debug.Log($"New highscore is {score}");
        }
    }
    private int GetHighScore()
    {
        var i = PlayerPrefs.GetInt("Highscore");
        return i;
    }

}
