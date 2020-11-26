using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public bool paulHaMelech = true;

    private Rigidbody _myRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementVertical = Input.GetAxis("Vertical");
        float movementHorizontal = Input.GetAxis("Horizontal");
        
        Vector3 movement = new Vector3(movementHorizontal, 0f,movementVertical);
        
        _myRigidbody.AddForce(movement * speed);
        
    }
}
