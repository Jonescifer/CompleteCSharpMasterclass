using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int _scorePlayer1 = 0;
    private int _scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int _goalToWin = 3;

    // Update is called once per frame
    void Update()
    {
        if (_scorePlayer1 >= _goalToWin || _scorePlayer2 >= _goalToWin)
        {
            Debug.Log("Game Wonnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn!");
        }
    }

    private void FixedUpdate()
    {
        Text uiScorePalyer1 = this.scoreTextPlayer1.GetComponent<Text>();
        uiScorePalyer1.text = _scorePlayer1.ToString();
        
        Text uiScorePalyer2 = this.scoreTextPlayer2.GetComponent<Text>();
        uiScorePalyer2.text = _scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        this._scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        this._scorePlayer2++;
    }
}