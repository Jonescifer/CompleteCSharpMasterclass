using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForObjects : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 100))
        {
            print($"we hit a {hit.collider.gameObject.name} at distance of {hit.distance}.");
        }
        else
        {
            print("nothing underneath us");
        }
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            print($"we hit a {hit.transform.name} at distance of {hit.distance}.");
        }

        else
        {
            print("nothing underneath us");
        }
            
    }
}
