using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavingData : MonoBehaviour
{
    private int _number = 0;
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
            _number++;
            if (_number > GetNumber())
            {
                PlayerPrefs.SetInt("score",_number);
            }
            Debug.Log($"the Number is {_number}");
        }
    }

    private int GetNumber()
    {
        int score = PlayerPrefs.GetInt("score", 0);
        return score;
    }
}
