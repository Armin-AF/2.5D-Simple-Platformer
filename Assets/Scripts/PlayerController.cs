using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody myRigidbody;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 500f;
    
    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");

        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);

        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        if (jumpInput)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
