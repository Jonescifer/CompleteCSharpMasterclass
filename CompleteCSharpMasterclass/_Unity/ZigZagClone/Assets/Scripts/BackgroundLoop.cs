using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private static BackgroundLoop _instanceBackgroundLoop;
    private void Awake()
    {
        //destroy the instance that is created after the first game loss..
        if (_instanceBackgroundLoop == null)
        {
            _instanceBackgroundLoop = this;
        }else if (_instanceBackgroundLoop!= this)
        {
         Destroy(gameObject);   
        }
        DontDestroyOnLoad(gameObject);
    }
}
