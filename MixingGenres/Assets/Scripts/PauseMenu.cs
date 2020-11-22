using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isGamePaused = false;

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
        isGamePaused = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        isGamePaused = false;
    }
}
