using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public SceneManager sceneManager;
    
    // Start is called before the first frame update
    void Start()
    {
        sceneManager.updatePlayerSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
