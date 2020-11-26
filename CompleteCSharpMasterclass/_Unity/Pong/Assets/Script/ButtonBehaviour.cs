using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR;

public class ButtonBehaviour : MonoBehaviour
{
    public Text scoreText;

    public void OnButtonPressed()
    {
        scoreText.text = "Button was pressed";
    }
}
