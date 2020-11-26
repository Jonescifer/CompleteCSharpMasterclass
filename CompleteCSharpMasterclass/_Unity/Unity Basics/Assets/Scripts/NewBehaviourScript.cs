using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Start Method was called");
        float myRandomNumber = Random.Range(0f, 15f);
        print($"Start random number: {myRandomNumber}");
    }

    // Update is called once per frame
    void Update()
    {
        print("Update Method was called");
        float myRandomNumber = Random.Range(0f, 15f);
        print($"Updated random number: {myRandomNumber}");
    }
}
