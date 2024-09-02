using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for loading scenes

public class LevelDone : MonoBehaviour
{
    public GameObject LevelCompletedUI; // Assign this in the inspector

    // Call this method to complete the level
    public void CompleteLevel()
    {
        LevelCompletedUI.SetActive(true); // Show the level completed sign
        Time.timeScale = 0f; // Pause the game time, stopping most game functions
    }

    // Called when restart button is clicked.
    public void RestartLevel()
    {
        Time.timeScale = 1f; // Make sure the game's time scale is reset
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reloads the current scene
    }
}
