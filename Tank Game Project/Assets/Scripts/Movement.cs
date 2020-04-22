using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    PlayerControls controls;

    Vector3 move;

    private void Awake()
    {
        controls = new PlayerControls();        
    }

    void Update()
    {
       move.x = controls.InputControler.LeftCirclePad.performed +=  
    }

    void OnEnable()
    {
        controls.InputControler.Enable();
    }

    void OnDisable()
    {
        controls.InputControler.Disable();
    }
}

