using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controlls the shooting logic for the player
/// </summary>
public class PlayerShoot : MonoBehaviour
{
    // Bullet preFab that is being fired
    public GameObject bullet;
    public float bulletSpeed = 35;
    private Rigidbody2D bulletRb;

    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bulletRb = bullet.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            bulletRb.transform.position = rb.transform.position;
            Instantiate(bullet);
            bulletRb.velocity = new Vector2(rb.velocity.x + bulletSpeed, rb.velocity.y + bulletSpeed);
        }
    }
}
