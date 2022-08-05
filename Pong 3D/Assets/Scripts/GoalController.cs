using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;
    public SpawnManager spawnManager;
    public bool isP1;
    public bool isP2;
    public bool isP3;
    public bool isP4;
    public AudioSource wallCollision;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (isP1 && manager.p1Score <manager.maxscore)
            {
                Destroy(collision.gameObject);
                manager.Addp1Score(1);
                spawnManager.ballCount--;
                
            }
            else if (isP2 && manager.p2Score < manager.maxscore)
            {
                Destroy(collision.gameObject);
                manager.Addp2Score(1);
                spawnManager.ballCount--;
                
            }
            else if (isP3 && manager.p3Score < manager.maxscore)
            {
                Destroy(collision.gameObject);
                manager.Addp3Score(1);
                spawnManager.ballCount--;
                
            }
            else if (isP4 && manager.p4Score < manager.maxscore)
            {
                Destroy(collision.gameObject);
                manager.Addp4Score(1);
                spawnManager.ballCount--;
                
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            wallCollision.Play();
        }
    }
}
