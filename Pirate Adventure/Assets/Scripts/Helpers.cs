using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Holds misc custom methods to clean up complexity
/// </summary>
public static class Helpers 
{
    /// <summary>
    /// Opens a new scene and switches to it
    /// </summary>
    /// <param name="sceneName"></param>
    public static void OpenNewScene(string sceneName) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        
    }

    /// <summary>
    /// Switches to an already open scene and deletes current scene
    /// </summary>
    /// <param name="sceneName"></param>
    public static void SwitchScene(string sceneName, string curScene)
    {
        UnityEngine.SceneManagement.SceneManager.SetActiveScene(UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneName));
        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(curScene);
    }

    /// <summary>
    /// Changes the current scene to the selected one. Deletes the current scene
    /// </summary>
    /// <param name="sceneName"></param>
    public static void ChangeScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
