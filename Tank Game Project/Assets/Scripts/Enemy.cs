using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour   
{
    public GameObject player;
    public int speed;
         
     //Update is called once per frame
    void Update()
    {        
        Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        transform.position += transform.forward * speed * Time.deltaTime;

    }
}
