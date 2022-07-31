using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{
    [SerializeField] float powerThrust = 100f; //발사체의 추진력 상수값
    [SerializeField] float rotationThrust = 1f; // 회전 상수값
    Rigidbody rb;
    AudioSource audioSource;

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        // audioSource = GetComponent<AudioSource>();
    }

    void Update() 
    {
        ProcessThrust();
    }

    void ProcessThrust()
    {
        if(Input.Getkey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * powerThrust * Time.deltaTime);
        }
    }


    // private void OnCollisionEnter(Collision other) 
    // {
        
    // }


}       