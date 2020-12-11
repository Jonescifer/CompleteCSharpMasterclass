using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{
    public Transform prefab;
    private float _counter = 0;

    void Start()
    {
        InvokeRepeating("CreateNewCube", 0,1);
    }

    public void CreateNewCube()
    {
        Instantiate(prefab, new Vector3( -10 + _counter * 1.666666666666667f, 0, 0 ), Quaternion.identity);
        _counter++;
        if (_counter >= 10)
        { 
            CancelInvoke();
        }
    }
}
