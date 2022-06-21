using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is an object that has access to everything in the scene.
/// We use this object to manage information on the scene and control the overarching logic
/// </summary>
public class SceneManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject PlayerSpawnPoint;

    public static int playerMaxHealth = 5;
    public static int playerHealth = 5;
    private SpriteRenderer playerSpriteRenderer;
    public List<Sprite> playerHealthSprites;

    private static GameObject player;
    private static bool isSpawned = false;

    /// <summary>
    /// Damages player by an amount of damage
    /// </summary>
    /// <param name="damage"></param>
    public void damagePlayer(int damage)
    {
        playerHealth -= damage;
        
        if (playerHealth <= 0)
        {
            lose();
        }
        
        updatePlayerSprite();
    }

    /// <summary>
    /// Updates the sprite for the player based on the health
    /// </summary>
    public void updatePlayerSprite()
    {
        int spriteIndex = ((playerMaxHealth / playerHealthSprites.Count) * playerHealth) - 1;
        
        if (spriteIndex >= 0 && spriteIndex < playerHealthSprites.Count) {
            playerSpriteRenderer.sprite = playerHealthSprites[spriteIndex];
        }
        
    }

    /// <summary>
    /// This will run the lose logic after the lose condition has been met
    /// </summary>
    public void lose()
    {
        Helpers.ChangeScene("LoseScene");
    }
    
    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!isSpawned)
        {
            playerPrefab.transform.position = PlayerSpawnPoint.transform.position;
            player = Instantiate(playerPrefab);
            playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
            isSpawned = true;
        }
        updatePlayerSprite();
    }

    // Update is called once per frame
    void Update()
    {
        updatePlayerSprite();
    }
    
}
