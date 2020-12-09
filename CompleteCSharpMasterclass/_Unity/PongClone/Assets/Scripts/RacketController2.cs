using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController2 : MonoBehaviour
{
    private float _movementSpeed = 200;

    private void FixedUpdate()
    {
        float userInput = Input.GetAxisRaw("Vertical2");
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,userInput)*_movementSpeed;//set velocity to keyboard input times movement speed.
       
    }
}
