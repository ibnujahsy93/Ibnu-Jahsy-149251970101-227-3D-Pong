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

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (isP1)
            {
                Destroy(collision.gameObject);
                manager.Addp1Score(1);
                spawnManager.ballCount--;
                
            }
            else if (isP2)
            {
                Destroy(collision.gameObject);
                manager.Addp2Score(1);
                spawnManager.ballCount--;
                
            }
            else if (isP3)
            {
                Destroy(collision.gameObject);
                manager.Addp3Score(1);
                spawnManager.ballCount--;
                
            }
            else if (isP4)
            {
                Destroy(collision.gameObject);
                manager.Addp4Score(1);
                spawnManager.ballCount--;
                
            }
        }
    }
}
