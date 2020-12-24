using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public static BackgroundLoop _InstanceBackgroundLoop;
    private void Awake()
    {
        if (_InstanceBackgroundLoop == null)
        {
            _InstanceBackgroundLoop = this;
        }else if (_InstanceBackgroundLoop!= this)
        {
         Destroy(gameObject);   
        }
        DontDestroyOnLoad(gameObject);
    }
}
