using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartTheGame()
    {
        SceneManager.LoadScene("ExpansumGame");

    }

    public void OpenLeaderboard()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
