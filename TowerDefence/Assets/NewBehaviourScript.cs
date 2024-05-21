using UnityEngine;

public enum GamePause
{
    Playing,
    Paused
}

public class NewBehaviourScript : MonoBehaviour
{
    public GamePause currentState = GamePause.Playing;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        if (currentState == GamePause.Playing)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    void PauseGame()
    {
        currentState = GamePause.Paused;
        Time.timeScale = 0f; // Pause time
        // Optionally, you can show a pause menu or do other pause-related actions
        Debug.Log("Game Paused");
    }

    void ResumeGame()
    {
        currentState = GamePause.Playing;
        Time.timeScale = 1f; // Resume time
        // Optionally, you can hide the pause menu or do other resume-related actions
        Debug.Log("Game Resumed");
    }
}

