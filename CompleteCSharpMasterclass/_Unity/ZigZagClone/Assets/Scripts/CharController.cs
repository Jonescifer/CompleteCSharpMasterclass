using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class CharController : MonoBehaviour
{
    //for navigation
    private Rigidbody _rigidbody;
    private bool _isWalkingRight = true;
    
    //For trigering animations and falling detection.
    public Transform rayStart;
    private Animator _animator;
    
    //GameMenager
    private GameManager _gameManager;

    //Particle Effect
    public GameObject crystalEffect;
    

    private void Awake()
    {
        //initialize rigidbody component
        _rigidbody = GetComponent<Rigidbody>();
        
        //initialize animator component! (error was: NullReferenceException: Object reference not set to an instance of an object CharController.Update () (at Assets/Scripts/CharController.cs:37)
        _animator = GetComponent<Animator>();
        
        //initialize GameManager via search a game object (we only have one..)
        _gameManager = FindObjectOfType<GameManager>();
        
    }

    private void FixedUpdate()
    {
        if (!_gameManager.gameStarted)
        {
            return;
        }
        else
        {
            _animator.SetTrigger("gameStarted");
        }
        
        //moving player forward.
        _rigidbody.transform.position = transform.position + transform.forward * (Time.deltaTime *2) ;
        
    }

    private void Update()
    {
        
            //when pressing space do this:
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SwitchDirection();
            }

            //check if Falling!
            CheckGround();
    }

    private void CheckGround()
    {
        //set animation to falling
        RaycastHit raycastHit;
        if (!Physics.Raycast(rayStart.position, -transform.up, out raycastHit, Mathf.Infinity))
        {
            _animator.SetTrigger("isFalling");
        }
        else
        {
            _animator.SetTrigger("isNotFalling");
        }
        
        //check if player has fallen and end Game.
        if (transform.position.y < -2)
        {
            _gameManager.EndGame();
        }
    }

    private void SwitchDirection()
    {
        //if game is started you can switch
        if (!_gameManager.gameStarted)
        {
            return;
        }

        if (_isWalkingRight)
        {
            _rigidbody.transform.rotation = Quaternion.Euler(0, -45, 0);
        }
        else
        {
            _rigidbody.transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        
        //make not true
        _isWalkingRight = !_isWalkingRight;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Crystal"))
        {
            _gameManager.IncreaseScore();
            
            GameObject g = Instantiate(crystalEffect, rayStart.transform.position,Quaternion.identity);
            Destroy(g,1);
            Destroy(other.gameObject);
        }
    }
}
