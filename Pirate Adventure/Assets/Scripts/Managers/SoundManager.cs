using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages information about sound effects and music
/// </summary>
public class SoundManager : MonoBehaviour
{
    public List<AudioSource> audioSources;

    public void PlayAudio(string sourceName)
    {
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.name == sourceName)
            {
                audioSource.Play();
            }
        }
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
