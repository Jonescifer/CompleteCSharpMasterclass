using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionController : MonoBehaviour
{
    //access to ballController script
    public BallController ballController;
    public FieldScoreController fieldScoreController;

    void BounceAngle(Collision2D other)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = other.transform.position;
        float racketHeight = other.collider.bounds.size.y;
        
        //at witch direction to bounce...in X. Horisontal.
        float xDirection;
        if (other.gameObject.name == "RacketPlayer1")
        {
            xDirection = 1;
        }else
        {
            xDirection = -1;
        }

        //at which ANGLE to bounce in Y, Vertical.
        float yDirection = (ballPosition.y - racketPosition.y) / racketHeight;
        
        //counter update
        ballController.IncreaseHitCounter();
        Debug.Log("increased Counter method");
        ballController.MoveBall(new Vector2(xDirection,yDirection));

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "RacketPlayer1"|| other.gameObject.name == "RacketPlayer2" )
        {
            BounceAngle(other);
        }else if(other.gameObject.name == "WallLeft")
        {
            Debug.Log("Wall Left was Hit, Player 1 lost round.");
            //start again
            StartCoroutine(ballController.StartBallMovement(true));
            //update score
            fieldScoreController.ScorePlayer2();
        }else if (other.gameObject.name == "WallRight")

        {
            ballController.ResetBall(false);
            Debug.Log("Wall Right was Hit, Player 2 lost round.");
            StartCoroutine(ballController.StartBallMovement(false));
            fieldScoreController.ScorePlayer1();
        }
    }
}
