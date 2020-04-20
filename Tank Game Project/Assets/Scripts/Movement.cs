using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 movement;

    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z= Input.GetAxis("Vertical");


    }
}
