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
    // TODO: hold static public fields for info that needs to last between scenes
    //  - Player health, score, money, etc
    public GameObject player;
    public GameObject PlayerSpawnPoint;

    private static bool isSpawned = false;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!isSpawned)
        {
            player.transform.position = PlayerSpawnPoint.transform.position;
            Instantiate(player);
            DontDestroyOnLoad(player);
            isSpawned = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
