using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public Transform rayStart;
    
    private Rigidbody _rb;
    private bool _walkingRight = true;
     private Animator _animator;
    private GameManager _gameManager;
   

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
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
        
        LockCamera();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchDirection();
        }
        
        CheckGround();
        
    }

    private void SwitchDirection()
    {
        if (!_gameManager.gameStarted)
        {
            return;
        }
        if (_walkingRight)
        {
            transform.rotation = Quaternion.Euler(0,-45,0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,45,0);
        }
        _walkingRight = !_walkingRight;
    }

    private void CheckGround()
    {
        RaycastHit raycastHit;
                
                if (!Physics.Raycast(rayStart.position, -transform.up, out raycastHit, Mathf.Infinity))// see that if not true!
                {
                    _animator.SetTrigger("isFalling");
                }

                if (transform.position.y < -2)
                {
                    _gameManager.EndGame();
                }
    }

    private void LockCamera()
    {
        _rb.transform.position = transform.position + transform.forward * (Time.deltaTime*2);
    }
}
