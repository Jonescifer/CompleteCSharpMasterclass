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
        Debug.Log($"Touched: {gameObject.name}!");// tell me which fruit i triggered..
        
        var transformInst = transform;
        GameObject instSlicedFruit = Instantiate(slicedFruit, transformInst.position, transformInst.rotation);//instantiate the GAME OBJECT the slice fruit prefab at the fruit's position.
        
        Rigidbody[] rbsOnSliced = instSlicedFruit.transform.GetComponentsInChildren<Rigidbody>();//Create rigidbody array - get componentS 
        
        foreach (var r in rbsOnSliced)// add explosion force to the children .
        {
            r.transform.rotation = Random.rotation;
            r.AddExplosionForce(Random.Range(500, 1000), transform.position, 5f);
        }
        
        FindObjectOfType<GameManager>().IncreaseScore(3);//increase the score! 
        
        Destroy(gameObject);//destroy the fruit - when exploded.
        Destroy(instSlicedFruit.gameObject, 3);//destroy the cut fruit. so it doesnt live forever.

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
    
