using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void MoveToScene(int sceneId) //we pass the method an integer of the scene ID that is represented in the build settings.
    {
        SceneManager.LoadScene(sceneId);
    }
    
}
