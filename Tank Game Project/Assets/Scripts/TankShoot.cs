using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TankShoot : MonoBehaviour
{
    public Rigidbody shell;
    public Transform sFireTransform;
 
    public int sMinLaunchForce;
    public int sMaxLaunchForce;
    public float sMaxChargeTime;

    private string sFireButton;
    private float sCurrentLaunchForce;
    private float sChargeSpeed;
    public bool sFired;

    private int timecleaner;

    // Start is called before the first frame update
    void Start()
    {
        sFireButton = "Fire1";

        sChargeSpeed = (sMaxLaunchForce - sMinLaunchForce) / sMaxChargeTime;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (sCurrentLaunchForce >= sMaxLaunchForce && !sFired)
        {
            sCurrentLaunchForce = sMaxLaunchForce;
            Fire();
        }

        else if (Input.GetButtonDown(sFireButton))
        {
            sFired = false;
            sCurrentLaunchForce = sMinLaunchForce;
        }

        else if (Input.GetButton(sFireButton) && !sFired)
        {
            sCurrentLaunchForce += sChargeSpeed * Time.deltaTime;  
        }

        else if (Input.GetButtonUp(sFireButton) && !sFired)
        {
            Fire();
        }

    }

    private void Fire()
    {
        sFired = true;

        Rigidbody shellinstance = Instantiate(shell, sFireTransform.position, sFireTransform.rotation) as Rigidbody;

        shellinstance.velocity = sCurrentLaunchForce * sFireTransform.forward;

        sCurrentLaunchForce = sMinLaunchForce;

        
    }
}
