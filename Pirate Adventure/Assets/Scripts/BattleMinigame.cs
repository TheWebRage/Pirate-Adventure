using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds the logic for the actual Mini Game
/// </summary>
public class BattleMinigame : MonoBehaviour
{
    // Bar that slides over the colored "hit meter"
    public int speed = 50;
    public float leftBar;
    public float rightBar;
    public float winLeft;
    public float winRight;
    public GameObject bar;
    public float pauseTime = 0.0f;
    public GameObject sceneManager;
    
    private Rigidbody2D meterRb;
    private SpriteRenderer meterSpriteRenderer;
    private Rigidbody2D barRb;
    private int direction = 1;
    private int tempSpeed = 0;

    private float nextActionTime = 0.0f;
    public float period = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        meterRb = GetComponent<Rigidbody2D>();
        meterSpriteRenderer = GetComponent<SpriteRenderer>();
        barRb = bar.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Find the direction for the bar
        if (barRb.position.x > rightBar) // TODO: find auto way to find right and left bar
        {
            direction = -1;
        }
        if (barRb.position.x < leftBar)
        {
            direction = 1;
        }
        // Move the bar
        barRb.velocity = new Vector2(speed * direction, 0);
        
        // TODO: lose minigame condition

        nextActionTime += Time.deltaTime;
        
        if (Input.GetKey(KeyCode.Space))
        {
            if (nextActionTime >= period)
            {
                nextActionTime = 0;

                if (barRb.position.x > winLeft && barRb.position.x < winRight)
                {
                    // Win condition
                    Helpers.SwitchScene("SampleScene", "BattleScene");
                }
                else
                {
                    //Lose Health 
                    sceneManager.GetComponent<SceneManager>().damagePlayer(1);
                }
            }
        }
        
    }
}
