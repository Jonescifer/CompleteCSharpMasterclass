using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _score;
    private int _highScore;
    
    [Header("Score Elements")]
    public Text scoreText;
    public Text highScoreText;
    
    
    [Header("GameOver")]
    public GameObject gameOverPanel;
    public Text gameOverPanelScoreText;
    public Text gameOverPanelHighScoreText;

    private void Awake()
    { 
        gameOverPanel.SetActive(false);
        GetHighscore();
    }

    private void GetHighscore()
    {
        _highScore = PlayerPrefs.GetInt("Highscore");
        highScoreText.text = "Best: " + PlayerPrefs.GetInt("Highscore");
    }

    public void IncreaseScore(int points)
    {
        _score += points;
        scoreText.text = _score.ToString();
        
        if (_score > _highScore)
        {
            PlayerPrefs.SetInt("Highscore",_score);
            highScoreText.text = "Best: " + PlayerPrefs.GetInt("Highscore");
        }
    }

    public void OnBombHit()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        gameOverPanelScoreText.text = "Score: " + _score.ToString();
        gameOverPanelHighScoreText.text = "Best: " + PlayerPrefs.GetInt("Highscore");
        
        Debug.Log("bomb hit");
        
    }

    public void RestartGame()
    {
        _score = 0;
        scoreText.text = _score.ToString();
        PlayerPrefs.SetInt("Highscore",_highScore);
        gameOverPanel.SetActive(false);
        GameObject[] interactableGameObject = GameObject.FindGameObjectsWithTag("Interactable");
        
        foreach (var i in interactableGameObject)
        {
            Destroy(i);
        }
        
        Time.timeScale = 1;
        
        
        
    }
    public void ResetHighScore()
         {
             PlayerPrefs.SetInt("Highscore",0);
             highScoreText.text = "Best: " + PlayerPrefs.GetInt("Highscore");
         }
}
