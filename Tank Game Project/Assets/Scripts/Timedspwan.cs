using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timedspwan : MonoBehaviour
{
    public GameObject item;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    public void Start()
    {
        Instantiate(item, transform.position, transform.rotation);
    }

    public void Spawnobject()
    {

        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
