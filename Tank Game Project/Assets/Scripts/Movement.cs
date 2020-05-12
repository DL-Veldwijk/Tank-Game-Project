using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    private Vector3 bodyMovement;
    public float speed;

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
        bodyMovement.x = Input.GetAxis("LeftCirclePadHor");
        bodyMovement.z = Input.GetAxis("LeftCirclePadVer");
        transform.Translate(bodyMovement * speed * Time.deltaTime);

    }
}

