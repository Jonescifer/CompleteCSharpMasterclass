using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float movementSpeed = 400;//of ball
    public float extraSpeedPerHit = 50;//extra speed each hit
    public float maximumSpeed = 1000;//top speed
    private int _hitCounter;

    //coroutine with the method StartBallMovement;
    private void Start()
    {
        StartCoroutine(StartBallMovement(true));
    }
    
    //Method for reseting the game after round won/lost
    public void ResetBall(bool isStartingPlayer1 = true)
    {
        GetComponent<Rigidbody2D>().velocity=new Vector2(0,0);// reset velocity to 0!
        if (isStartingPlayer1)
        {
            gameObject.transform.localPosition = new Vector3(-100,0,0);
        }
        else
        {
            gameObject.transform.localPosition = new Vector3(100,0,0);
        }
        
        
    }
    
    //IEnumerator method so it can be called as a coroutine.. inside this method the MoveBall method is called (?)
    public IEnumerator StartBallMovement(bool isStartingPlayer1 = true)
    {
        ResetBall(isStartingPlayer1);
        _hitCounter = 0;//reset hit counter.
        yield return  new WaitForSeconds(1);//wait for 1 second before starting game.
        if (isStartingPlayer1)
        {
            MoveBall(new Vector2(-1, 0));//move ball right towards player 1;
        }
        else
        {
            MoveBall(new Vector2(1,0));//move ball right towards player 2
        }
    }

    //The method that moves the ball..
    public void MoveBall(Vector2 vec2)
    {
        vec2 = vec2.normalized;
        
        float speed = movementSpeed + _hitCounter * extraSpeedPerHit; // define speed;
        
        GetComponent<Rigidbody2D>().velocity = vec2 * speed; //create rigidbody2d object inside method.
        }

    public void IncreaseHitCounter()
    {
        if (_hitCounter * extraSpeedPerHit <= maximumSpeed)
        {
            _hitCounter++;
            Debug.Log($"The Hit Counter is{_hitCounter}");
        }
        
    }
}
