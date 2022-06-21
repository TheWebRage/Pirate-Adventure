using UnityEngine;
using System;

/// <summary>
/// Holds information and logic for the player movement
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 0.1f;
    
    private float nextActionTime = 0.0f;
    public float period = 1.0f;

    public float maxSpeed = 20.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        nextActionTime += Time.deltaTime;
        if (nextActionTime >= period)
        {
            nextActionTime -= period;

            // X-Axis logic
            if (Math.Abs(rb.velocity.x) <= maxSpeed)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    //rb.velocity = new Vector2(speed, rb.velocity.y);
                    rb.AddForce(new Vector2(speed, rb.velocity.y));
                    //rb.position = new Vector2(rb.position.x + speed, rb.position.y);
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    //rb.velocity = new Vector2(-speed, rb.velocity.y);
                    rb.AddForce(new Vector2(-speed, rb.velocity.y));
                    //rb.position = new Vector2(rb.position.x - speed, rb.position.y);
                }
                else
                {
                    //rb.velocity = new Vector2(0, rb.velocity.y);
                }
            }

            // Y-Axis Logic
            if (Math.Abs(rb.velocity.y) <= maxSpeed)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    //rb.velocity = new Vector2(rb.velocity.x, speed);
                    rb.AddForce(new Vector2(rb.velocity.x, speed));
                    //rb.position = new Vector2(rb.position.x, rb.position.y + speed);
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    //rb.velocity = new Vector2(rb.velocity.x, -speed);
                    rb.AddForce(new Vector2(rb.velocity.x, -speed));
                    //rb.position = new Vector2(rb.position.x, rb.position.y - speed);
                }
                else
                {
                    //rb.velocity = new Vector2(rb.velocity.x, 0);
                }
            }
            
        
        }
    }
}