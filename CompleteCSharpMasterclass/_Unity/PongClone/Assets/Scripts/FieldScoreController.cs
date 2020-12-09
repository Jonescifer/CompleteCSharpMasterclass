using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FieldScoreController : MonoBehaviour
{
    private int _scorePlayer1 = 0;
    private int _scorePlayer2 = 0;

    public GameObject ScorePlayer1Text;
    public GameObject ScorePlayer2Text;

    private int _winGoal = 3;

    public void ScorePlayer1()
    {
        _scorePlayer1++;
    }
    public void ScorePlayer2()
    {
        _scorePlayer2++;
    }

    private void Update()
    {
        if (_scorePlayer1 >= _winGoal || _scorePlayer2 >= _winGoal)
        {
            Debug.Log("Game Won!");
            SceneManager.LoadScene(2);
        }
    }

    private void FixedUpdate()
    {
        //update text compnent in ui...
        ScorePlayer1Text.GetComponent<Text>().text= _scorePlayer1.ToString();
        ScorePlayer2Text.GetComponent<Text>().text= _scorePlayer2.ToString();
        
    }
}
