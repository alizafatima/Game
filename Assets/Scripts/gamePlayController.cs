using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//A comment is added in the gamePlayController

public class gamePlayController : MonoBehaviour 
{
    public GameObject gamePlayPanel;
    public GameObject pausePanel;

    public void openPausePanel()
    {
        gamePlayPanel.SetActive(false);
        pausePanel.SetActive(true);
    }
    public void pauseButton()
    {
        pausePanel.SetActive(false);
        gamePlayPanel.SetActive(true);
    }
    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
