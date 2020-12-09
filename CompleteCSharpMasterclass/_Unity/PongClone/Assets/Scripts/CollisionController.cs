using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;//position of ball
        Vector3 racketPosition = c.transform.position;//position of racket
        float racketHeight = c.collider.bounds.size.y;// size of the racket in y.

        float x;
        if (c.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;
        
        this.ballMovement.IncreaseHitCounter();//calls increase hit counter method!
        this.ballMovement.MoveBall(new Vector2(x,y));
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "RacketPlayer1" || other.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromRacket(other);
        }
        else if(other.gameObject.name == "WallLeft" )
        {
            Debug.Log("Collision with wall left");
            scoreController.GoalPlayer2();
        }else if(other.gameObject.name == "WallRight" )
        {
            scoreController.GoalPlayer1();
            Debug.Log("Collision with wall right");
        }
    }
}
