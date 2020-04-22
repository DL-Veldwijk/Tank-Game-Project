using UnityEngine;

public class Timespawn : MonoBehaviour
{
    public GameObject item;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    private void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

    }

    public void SpawnObject()
    {
        Instantiate(item, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
