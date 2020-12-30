using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public bool gameStarted;
    public int score;
    public Text scoreText;
    public Text highScoreText;

    private void Awake()
    {
        //PlayerPrefs.SetInt("High score", score); //reset the highscore
        highScoreText.text = "Best: " + GetHighScore().ToString();
    }

    

    private void StartGame()
    {
        gameStarted = true;
        //call method on Road - start building.
        FindObjectOfType<Road>().StartBuilding();
    }

    private void Update()
    {
        //if return was pressed start game.
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }

      
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();

        if (score > GetHighScore())
        {
            PlayerPrefs.SetInt("High score", score);
            highScoreText.text = "Best: " + GetHighScore().ToString();
        }
    }
    private int GetHighScore()// get high score method
    {
        var i = PlayerPrefs.GetInt("High score");
        return i;
    }

}
