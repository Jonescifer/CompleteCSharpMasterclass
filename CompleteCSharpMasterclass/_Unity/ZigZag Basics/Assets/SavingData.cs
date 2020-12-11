using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavingData : MonoBehaviour
{
    private int _numberCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"stored number is {GetNumber()}");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _numberCounter++;
            if (_numberCounter >= GetNumber())
            {
                PlayerPrefs.SetInt("score",_numberCounter);
            }
            Debug.Log($"the Number is {_numberCounter}");
        }
    }

    private int GetNumber()
    {
        int score = PlayerPrefs.GetInt("score", 0);
        return score;
    }
}
