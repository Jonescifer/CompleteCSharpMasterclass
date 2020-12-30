using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject slicedFruit;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateSlicedFruit();
        }
    }


    public void CreateSlicedFruit()
    {
        //instantiate the slice fruit prefab at the fruit's position.
        var thisTransform = transform;
        GameObject inst = (GameObject)Instantiate(slicedFruit, thisTransform.position, thisTransform.rotation);
        
        //Create rigidbody and explode!
        Rigidbody[] rigidbodiesOnSliced = inst.transform.GetComponentInChildren<Rigidbody>();
        
        
        
        //destroy the fruit
        Destroy(gameObject);
        
    }


}
    
