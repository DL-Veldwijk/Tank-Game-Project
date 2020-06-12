using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public float dieAfterTime;
    float timer;
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > dieAfterTime)
        {
            Destroy(gameObject);
        }
    }
}
