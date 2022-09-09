using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject startButton;
    public GameObject creditsButton;
    public GameObject creditsCanvas;
    public GameObject exitButton;
    public GameObject xButton;

    public void StartButton()
    {
        SceneManager.LoadScene("LevelOne");
    }
    public void CreditsButton()
    {
        startButton.SetActive(false);
        creditsButton.SetActive(false);
        creditsCanvas.SetActive(true);
        exitButton.SetActive(false);
        xButton.SetActive(true);
    }

    public void BackToMainMenu()
    {
        startButton.SetActive(true);
        creditsButton.SetActive(true);
        creditsCanvas.SetActive(false);
        exitButton.SetActive(true);
        xButton.SetActive(false);
    }

    public void ExitOption()
    {
        Application.Quit();
    }
}
