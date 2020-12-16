using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    private Vector3 m_offset;
    private void Awake()
    {
        m_offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        transform.position = target.position + m_offset;
    }
}
