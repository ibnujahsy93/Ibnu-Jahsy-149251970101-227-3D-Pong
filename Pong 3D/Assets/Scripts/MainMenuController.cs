using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void PlayGameVsBot()
    {
        SceneManager.LoadScene("GamevsBot");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("How To Play");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    
}
