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
    public GameObject bar;
    private Rigidbody2D meterRb;
    private SpriteRenderer meterSpriteRenderer;
    private Rigidbody2D barRb;
    private int direction = 1;
    
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
        
        // TODO: Find position when pressed
        // TODO: Win condition
        // TODO: lose health condition
        // TODO: lose minigame condition

        if (Input.anyKey)
        {
            // Temp win condition
            UnityEngine.SceneManagement.SceneManager.SetActiveScene(UnityEngine.SceneManagement.SceneManager.GetSceneByName("SampleScene"));
            UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync("BattleScene");
        }
    }
}
