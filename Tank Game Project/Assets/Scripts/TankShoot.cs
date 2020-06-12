using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TankShoot : MonoBehaviour
{
    private float mouse;
    public float mouseSense;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    // Update is called once per frame
    void Update()
    {
        mouse = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * mouse * mouseSense);    

    }

    
}
