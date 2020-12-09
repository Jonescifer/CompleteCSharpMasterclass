using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketContollerAI : MonoBehaviour
{
    private float _movementSpeed = 200;
    public GameObject ball;
    
    private void FixedUpdate()
    {
        if(Mathf.Abs(transform.position.x - ball.transform.position.x) > 50)
        {
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * _movementSpeed;
            }else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1)*_movementSpeed;
            }
        }else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
    }
}
