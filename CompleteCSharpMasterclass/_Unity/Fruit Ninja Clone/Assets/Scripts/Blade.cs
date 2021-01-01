using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Rigidbody2D _rb2D;

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        SetBladeToMouse();
    }

    private void SetBladeToMouse()
    {
        if (!(Camera.main is null))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = 10; //distance of 10 units from the camera.the fix for  the camera being 10 units back..
            _rb2D.position = Camera.main.ScreenToWorldPoint(mousePos);
        }
        else
        {
            throw new Exception("No Camera in scene");
        }
    }
}

