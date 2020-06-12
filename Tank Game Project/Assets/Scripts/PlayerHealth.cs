using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int health = 3;

    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            EditorSceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("EnemyAmmo"))
        {
            health--;
        }
        
            
        
    }
}
