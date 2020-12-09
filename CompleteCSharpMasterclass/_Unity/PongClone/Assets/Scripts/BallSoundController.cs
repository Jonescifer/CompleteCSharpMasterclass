using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "RacketPlayer1" || other.gameObject.name == "RacketPlayer2")
        {
            racketSound.Play();
        }else if (other.gameObject.name == "WallTop" || other.gameObject.name == "WallBottom")
        {
            wallSound.Play();
        }
    }
}
