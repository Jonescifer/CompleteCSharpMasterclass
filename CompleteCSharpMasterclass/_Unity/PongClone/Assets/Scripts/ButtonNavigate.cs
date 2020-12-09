using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNavigate : MonoBehaviour
{
    public void NavigateToScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
