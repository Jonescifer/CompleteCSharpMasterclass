using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;

    public float extraSpeedPerHit;

    public float maximumSpeed;

    private int _hitCounter = 0;
    
    void Start()
    {
        StartCoroutine(this.StartBall());// start a coroutine of StartBall
        Debug.Log("Started Coroutine!");
    }

    public void PositionBall(bool isStartingPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);//reset velocity.
        if (isStartingPlayer1)
        {
            this.transform.localPosition = new Vector3(-100,0,0);
        }
        else
        {
            this.transform.localPosition = new Vector3(100,0,0);
        }
    }
    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this._hitCounter = 0;//reset hitCounter.
        this.PositionBall(isStartingPlayer1);
        
        yield return new WaitForSeconds(1);//wait for 1 seconds

        if (isStartingPlayer1)
        {
            this.MoveBall(new Vector2(-1,0));
            Debug.Log("player 1 is true (default)!");
        }
        else
        {
            this.MoveBall(new Vector2(1,0));
            Debug.Log("player 2 is true (default)!");
        }
    }
    
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized; // normalize the direction.
        
        float speed = this.movementSpeed + (this._hitCounter * this.extraSpeedPerHit);// defining speed.

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>(); //assigning the component of this game object to a variable rigidBody2D.
        
        rigidbody2D.velocity = dir * speed; //assigning to velocity direction times speed.
        
    }

    public void IncreaseHitCounter()
    {
        if (this._hitCounter * this.extraSpeedPerHit < this.maximumSpeed)
        {
            _hitCounter++;
            Debug.Log(_hitCounter.ToString());
        }
    }
}
