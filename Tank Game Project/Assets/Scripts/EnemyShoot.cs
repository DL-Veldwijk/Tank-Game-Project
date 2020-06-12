using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyAmmo;
    public float delay = 1.0f;

    public GameObject enemyParent;
    public EnemyBehavior enemyBehaviorScript;


    private void Start()
    {
        enemyParent = gameObject.transform.root.gameObject;
        enemyBehaviorScript = enemyParent.GetComponentInChildren<EnemyBehavior>();
    }

    // Update is called once per frame
    void Update()
    {

        delay = Mathf.Clamp01(delay);

        if (delay > 0.0f)
        {
            delay -= Time.deltaTime;
        }

        if (delay < 0.1f)
        {
            delay = 1.0f;
        }

        if (enemyBehaviorScript.attack && delay == 1.0f)
        {
            Instantiate(enemyAmmo, transform.position, transform.rotation);
        }
    }
}
