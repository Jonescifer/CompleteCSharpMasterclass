using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform _target;
    private Vector3 _offsetVector3;
    private void Awake()
    {
        _offsetVector3 = transform.position - _target.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = _target.transform.position + _offsetVector3;
    }
}
