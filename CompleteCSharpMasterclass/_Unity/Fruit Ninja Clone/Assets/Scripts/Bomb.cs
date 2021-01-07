using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Blade blade = other.GetComponent<Blade>();
        if (!blade)
        {
            Debug.Log("Not Blade hit!");
            return;
        }

        Debug.Log("Blade!");
        FindObjectOfType<GameManager>().OnBombHit();


    }
}
