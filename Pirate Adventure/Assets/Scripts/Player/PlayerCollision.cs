using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Holds player interaction logic with other objects.
/// </summary>
public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When the collider interacts with something, it comes here first
    private void OnCollisionEnter2D(Collision2D other)
    {
        // If the object that was collided with has the enemy tag
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            
            // Open the battle scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("BattleScene", LoadSceneMode.Additive);
        }
    }

}
