using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Button playTheGame;
    public Button creditTheGame;
    public Button quitTheGame;

    public Button returnBtn;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void loadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void loadCreditScene()
    {
        SceneManager.LoadScene("Credit");
    }

    public void loadQuitScene()
    {
        Application.Quit();
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
