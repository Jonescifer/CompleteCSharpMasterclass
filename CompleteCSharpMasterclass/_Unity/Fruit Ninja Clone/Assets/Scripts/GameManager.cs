using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using Random = UnityEngine.Random;


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

    [Header("Sounds")] 
    public AudioClip bombSound;
    public AudioClip[] sliceSounds;
    private AudioSource _audioSource;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
        GetHighscore();
        _audioSource = GetComponent<AudioSource>();
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
        _audioSource.PlayOneShot(bombSound);
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

    public void PlayRandomSliceSound()
    {
        AudioClip randomSound = sliceSounds[Random.Range(0, sliceSounds.Length)];
        _audioSource.PlayOneShot(randomSound);
    }
}
