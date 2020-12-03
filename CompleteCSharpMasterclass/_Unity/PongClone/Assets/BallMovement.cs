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
        StartCoroutine(this.StartBall());
        Debug.Log("Started Coroutine!");
    }

    public IEnumerator StartBall(bool isStartPlayer1 = true)
    {
        this._hitCounter = 0;
        yield return new WaitForSeconds(2);//wait for 2 seconds

        if (isStartPlayer1)
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
    
    public void MoveBall(Vector2 dirVector2)
    {
        dirVector2 = dirVector2.normalized; // normalize the direction.
        
        float speed = this.movementSpeed + (this._hitCounter * this.extraSpeedPerHit);// defining speed.
        
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>(); //assigning the component of this game object to a variable rigidBody2D.
        
        rigidbody2D.velocity = dirVector2 * speed; //assigning to velocity direction times speed.
        
    }

    public void IncreaseHitCounter()
    {
        if (this._hitCounter * this.extraSpeedPerHit < this.maximumSpeed)
        {
            _hitCounter++;
        }
    }
}
