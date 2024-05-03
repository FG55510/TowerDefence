using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;

    [Header ("Pause")]
    public GameObject pausePanel;
    public string cena;
    public Button pauseButton; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseScreen();
        }
    }

    public void PauseScreen()
    {
        if (isPaused)
        {
            HideButton(); 
            isPaused = false;
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
        else
        {
            HideButton();
            isPaused = true;
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
    }

    public void HideButton()
    {
        pauseButton.interactable = !pauseButton.interactable;
    }



}
