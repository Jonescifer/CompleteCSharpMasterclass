using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource _wallSound;
    public AudioSource _racketSound;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "WallTop" || other.gameObject.name == "WallBottom")
        {
            _wallSound.Play();
        }else if (other.gameObject.name == "RacketPlayer1" || other.gameObject.name == "RacketPlayer2")
        {
            _racketSound.Play();
        }
    }
}
