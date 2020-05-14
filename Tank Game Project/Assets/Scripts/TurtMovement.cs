using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtMovement : MonoBehaviour
{ 

    public void Update()
    {
        DoAim();
    }

    public void DoAim()
    {
        Vector3 vNewInput = new Vector3(Input.GetAxis("RightCirclePadHor"), Input.GetAxis("RightCirclePadVer"), 0.0f);

        if(vNewInput.sqrMagnitude < 0.1f)
        {
            return;
        }

        var rotate = Mathf.Atan2(Input.GetAxis("RightCirclePadHor"), Input.GetAxis("RightCirclePadVer")) * Mathf.Rad2Deg;

        transform.localRotation = Quaternion.Euler(0, rotate, 0);     

    }
}
