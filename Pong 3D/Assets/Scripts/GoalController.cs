using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;
    public bool isP1;
    public bool isP2;
    public bool isP3;
    public bool isP4;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision = ball)
        {
            if (isP1)
            {
                manager.Addp1Score(1);
            }
            else if (isP2)
            {
                manager.Addp2Score(1);
            }
            else if (isP3)
            {
                manager.Addp3Score(1);
            }
            else if (isP4)
            {
                manager.Addp4Score(1);
            }
        }
    }
}
