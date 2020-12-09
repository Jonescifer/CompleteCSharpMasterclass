using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RacketPlayer2AI : MonoBehaviour
{
    public float movementSpeed = 200;
    public GameObject ball;
    
    private void FixedUpdate()// Update is called once per frame
    {
        if(Mathf.Abs(transform.position.y - ball.transform.position.y) > 50)
        {
            if (transform.position.y > ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1)* movementSpeed;
            }
            else if(transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,1)* movementSpeed; 
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,0); 
            }
        }
    }
}

