using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public GameObject ammo;
    public float thrust;
    public float timeBetweenShots = 0.1f;

    public float timeStamp;
    
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeStamp && (Input.GetButtonDown("Fire1")))
        {  
            Instantiate(ammo, transform.position, transform.rotation);
            GetComponent<Rigidbody>().AddForce(transform.forward);
            timeStamp = Time.time + timeBetweenShots;
        }

    }
}
