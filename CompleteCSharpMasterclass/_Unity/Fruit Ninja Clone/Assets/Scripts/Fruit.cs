using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Fruit : MonoBehaviour
{
    public GameObject slicedFruit;

    // private void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         CreateSlicedFruit();
    //     }
    // }


    public void CreateSlicedFruit()
    {
        //instantiate the slice fruit prefab at the fruit's position.
        GameObject inst = (GameObject)Instantiate(slicedFruit, transform.position, transform.rotation);
        
        //Create rigidbody array - get componentS 
        Rigidbody[] rbOnSliced = inst.transform.GetComponentsInChildren<Rigidbody>();

        foreach (var r in rbOnSliced)
        {
            r.transform.rotation = Random.rotation;
            r.AddExplosionForce(Random.Range(500,1000),transform.position,5f);
        }
        
        //destroy the fruit
        Destroy(gameObject);
        Destroy(inst.gameObject,5);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Blade blade = other.GetComponent<Blade>();

        if (!blade)
        {
            return;
        }
        CreateSlicedFruit();
    }
}
    
