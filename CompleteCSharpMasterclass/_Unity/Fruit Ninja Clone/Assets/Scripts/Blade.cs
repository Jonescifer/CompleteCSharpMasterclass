using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    private Camera _cameraMain;


    private void Awake()
    {
        _cameraMain = Camera.main;
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        SetBladeToMouse();
    }

    private void SetBladeToMouse()
    {
        
        if (!(_cameraMain is null))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = 10; //distance of 10 units from the camera.the fix for  the camera being -10.
            _rb2D.position = _cameraMain.ScreenToWorldPoint(mousePos);
        }
        else
        {
            throw new Exception("No Camera in scene");
        }
    }
}

