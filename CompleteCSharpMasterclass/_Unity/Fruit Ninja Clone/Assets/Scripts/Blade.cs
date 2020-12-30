using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
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
            mousePos.z = 10; //distance of 10 units from the camera.
            _rigidbody2D.position = Camera.main.ScreenToWorldPoint(mousePos);
        }
    }
}

