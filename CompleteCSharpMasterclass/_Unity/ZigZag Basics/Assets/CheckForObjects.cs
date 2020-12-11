using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForObjects : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        // if (Physics.Raycast(transform.position, Vector3.down, out _raycastHit, 100))
        // {
        //     print($"we hit {_raycastHit.collider.name} at distance {_raycastHit.distance}");
        // }
        // else
        // {
        //     print("we hit nothing");
        // }private Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit _raycastHit;
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out _raycastHit,100))
        {
            print($"we hit {_raycastHit.collider.name}");
        }
    }
}
