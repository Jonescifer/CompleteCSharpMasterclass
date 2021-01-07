using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Camera _cameraMain;
    private Rigidbody2D _rigidbody2D;
    
    public float minVelocity = 0.1f;
    private Vector3 _lastMousePosition;
    private Vector3 _mouseVelocity;
    private Collider2D _collider2D;
    
    private void Awake()
    {
        _cameraMain = Camera.main;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _collider2D = GetComponent<Collider2D>();//get the collider parameter of blade
    }

    private void Update()
    {
        _collider2D.enabled = IsMouseMoving();// make collider param enabled only when mouse is moving 
        SetBladeToMouse();
    }

    private void SetBladeToMouse()
    {
        
        if (!(_cameraMain is null))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = 10; //distance of 10 units from the camera.the fix for  the camera being -10.
            _rigidbody2D.position = _cameraMain.ScreenToWorldPoint(mousePos);
        }
        else
        {
            throw new Exception("No Camera in scene");
        }
    }

    private bool IsMouseMoving()
    {
        Vector3 currentMousePos = transform.position;
        
        float traveled = (_lastMousePosition - currentMousePos).magnitude;//length of the line between last mouse position to current.
        
        _lastMousePosition = currentMousePos;

        if (traveled > minVelocity)
        {
            return true;
        }
        return false;

    }
}

