using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _score;
    public Text scoreText;
    public Text highScoreText;

    private void Awake()
    {
        scoreText.text = _score.ToString();
        highScoreText.text = "Best: " + PlayerPrefs.GetInt("Highscore");
    }

    public void IncreaseScore(int points)
    {
        _score += points;
        scoreText.text = _score.ToString();
        int highScore = PlayerPrefs.GetInt("Highscore");
        if (_score > highScore)
        {
            PlayerPrefs.SetInt("Highscore",_score);
            highScoreText.text = "Best: " + PlayerPrefs.GetInt("Highscore");
        }
    }

    public void OnBombHit()
    {
        //Time.timeScale = 0;
        Debug.Log("bomb hit");
    }
}
