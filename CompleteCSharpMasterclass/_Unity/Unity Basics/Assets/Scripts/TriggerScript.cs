using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        print("CUBE IS Triggered");
        Destroy(gameObject);
    }
}
