using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBehaviour : MonoBehaviour
{
    public Text myText;
    private int _textNumber = 0;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _textNumber++;
            myText.text = _textNumber.ToString();

        }else if (Input.GetKeyDown(KeyCode.S))
        {
            myText.text = "S was pressed";
        }
    }
}
