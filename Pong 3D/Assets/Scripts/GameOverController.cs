using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject pauseMenuUi;
    public bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        pauseMenuUi.SetActive(true);
        GameIsPaused = true;
    }

    public void Replay()
    {
        pauseMenuUi.SetActive(false);
        SceneManager.LoadScene("Game");
        GameIsPaused = false;
    }
    public void BackToMainMenu()
    {
        pauseMenuUi.SetActive(false);
        GameIsPaused = false;
        SceneManager.LoadScene("Main Menu");
    }
    public void ReplayvsBot()
    {
        pauseMenuUi.SetActive(false);
        SceneManager.LoadScene("GamevsBot");
        GameIsPaused = false;
    }
}
