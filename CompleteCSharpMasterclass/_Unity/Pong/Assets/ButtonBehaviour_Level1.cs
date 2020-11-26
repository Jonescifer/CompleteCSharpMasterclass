
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour_Level1 : MonoBehaviour
{
    public void OnButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }
}
