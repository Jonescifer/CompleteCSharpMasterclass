using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{
    public Transform prefab;
    void Start()
    {
    //     for (int i = 0; i < 10; i++)
    //     {
    //         Instantiate(prefab, new Vector3(i * 1, i*-1, i*1 ), Quaternion.identity);
    //     }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, new Vector3( 1, -1, 1 ), Quaternion.identity);
        };
    }
}
