using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int p1Score;
    public int p2Score;
    public int p3Score;
    public int p4Score;

    public int maxscore;
    public BallController ball;
    

    public void Addp1Score(int increment)
    {
        p1Score += increment;
        
        if (p1Score >= maxscore)
        {
            GameOver();
        }
    }
    public void Addp2Score(int increment)
    {
        p2Score += increment;
        
        if (p2Score >= maxscore)
        {
            GameOver();
        }
    }
    public void Addp3Score(int increment)
    {
        p3Score += increment;
        
        if (p3Score >= maxscore)
        {
            GameOver();
        }
    }
    public void Addp4Score(int increment)
    {
        p4Score += increment;
        
        if (p4Score >= maxscore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }

    
}
