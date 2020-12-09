using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RacketPlayer2AI : MonoBehaviour
{
    public float movementSpeed = 200;
    public GameObject ball;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if (this.transform.position.y > ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1)* movementSpeed;
            }
            else if(this.transform.position.y < ball.transform.position.y)
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

