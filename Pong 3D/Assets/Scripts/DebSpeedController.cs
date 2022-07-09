using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebSpeedController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider ball;
    public Collider pad1;
    public Collider pad2;
    public Collider pad3;
    public Collider pad4;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (GameObject.Find("Ball(Clone)").GetComponent<BallController>().hitByPad1 == true)
            {
                Debug.Log("p1 debuff speed");
                pad1.GetComponent<PaddleController>().ActivateSlowSpeed();
                manager.RemovePowerUp(gameObject);


            }
            else if (GameObject.Find("Ball(Clone)").GetComponent<BallController>().hitByPad2 == true)
            {
                Debug.Log("p2 debuff speed");
                pad2.GetComponent<PaddleController>().ActivateSlowSpeed();
                manager.RemovePowerUp(gameObject);


            }
            else if (GameObject.Find("Ball(Clone)").GetComponent<BallController>().hitByPad3 == true)
            {
                Debug.Log("p3 debuff speed");
                pad3.GetComponent<PaddleController>().ActivateSlowSpeed();
                manager.RemovePowerUp(gameObject);


            }
            else if (GameObject.Find("Ball(Clone)").GetComponent<BallController>().hitByPad4 == true)
            {
                Debug.Log("p4 debuff speed");
                pad4.GetComponent<PaddleController>().ActivateSlowSpeed();
                manager.RemovePowerUp(gameObject);


            }
            else
            {
                manager.RemovePowerUp(gameObject);
            }


        }
        else
        {
            return;
        }

    }
}
