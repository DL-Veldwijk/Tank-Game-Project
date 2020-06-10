using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{

    private float hinput = 0;
    private float vinput = 0;
    public int movementspeed = 0;
    public int rotationspeed = 0;
    
    public Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        DoMove();
    }

    public void DoMove()
    {
        bodyMovement.x = Input.GetAxis("Horizontal");
        bodyMovement.z = Input.GetAxis("Vertical");
        transform.Translate(bodyMovement * speed * Time.deltaTime);
        
        transform.Rotate()
    }
}

