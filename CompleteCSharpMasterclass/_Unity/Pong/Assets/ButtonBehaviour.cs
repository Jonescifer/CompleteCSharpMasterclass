
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void OnButtonPressed()
    {
        SceneManager.LoadScene("Level 1");
    }
}
