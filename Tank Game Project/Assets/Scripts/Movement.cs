using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{

    public float moveSpeed;
    public float rotationSpeed;


    public void Update()
    {
        float rotateTank = Input.GetAxis("Horizontal");
        float moveTank = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed * moveTank;
       
        transform.Rotate(Vector3.up * rotationSpeed * rotateTank * Time.deltaTime);
       
    }
}

