using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketConroller1 : MonoBehaviour
{
    private float _movementSpeed = 200;

    private void FixedUpdate()
    {
        float userInput = Input.GetAxisRaw("Vertical");
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,userInput)*_movementSpeed;
       
    }
}
