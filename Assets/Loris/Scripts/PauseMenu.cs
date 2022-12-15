﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    //public GameObject settingsWindow;

    void Update()
    {
        
    }

    public void LoadMainMenu()
    {
        PlayerController.instance.Resume();
        SceneManager.LoadScene("MainMenu");
    }
    public void CreditsScene()
    {
        PlayerController.instance.Resume();
        SceneManager.LoadScene("Credits");
    }
}
