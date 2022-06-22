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
    public GameObject p1Pad;
    public GameObject p2Pad;
    public GameObject p3Pad;
    public GameObject p4Pad;
    public GameObject p1Wall;
    public GameObject p2Wall;
    public GameObject p3Wall;
    public GameObject p4Wall;
    


    public int maxscore;
    public BallController ball;
    public GameOverController gameOver;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public void Addp1Score(int increment)
    {
        p1Score += increment;
        
        if (p1Score >= maxscore)
        {
            p1Wall.GetComponent<Collider>().isTrigger = false;
            p1Pad.SetActive(false);
            
        }
        
    }
    public void Addp2Score(int increment)
    {
        p2Score += increment;
        
        if (p2Score >= maxscore)
        {
            p2Wall.GetComponent<Collider>().isTrigger = false;
            p2Pad.SetActive(false);
            
        }
        
    }
    public void Addp3Score(int increment)
    {
        p3Score += increment;
        
        if (p3Score >= maxscore)
        {
            p3Wall.GetComponent<Collider>().isTrigger = false;
            p3Pad.SetActive(false);
            
        }
        
    }
    public void Addp4Score(int increment)
    {
        p4Score += increment;

        if (p4Score >= maxscore)
        {
            p4Wall.GetComponent<Collider>().isTrigger = false;
            p4Pad.SetActive(false);
            
        }
        
    }

    

    public void Update()
    {
        if (p2Score == maxscore && p3Score == maxscore && p4Score == maxscore)
        {

            gameOver.GameOver();
            player1.SetActive(true);
            p1Wall.GetComponent<Collider>().isTrigger = false;


        }
        else if (p1Score == maxscore && p3Score == maxscore && p4Score == maxscore)
        {

            gameOver.GameOver();
            player2.SetActive(true);
            p2Wall.GetComponent<Collider>().isTrigger = false;

        }
        else if (p1Score == maxscore && p2Score == maxscore && p4Score == maxscore)
        {

            gameOver.GameOver();
            player3.SetActive(true);
            p3Wall.GetComponent<Collider>().isTrigger = false;

        }
        else if (p1Score == maxscore && p3Score == maxscore && p3Score == maxscore)
        {

            gameOver.GameOver();
            player4.SetActive(true);
            p4Wall.GetComponent<Collider>().isTrigger = false;

        }
    }


}
