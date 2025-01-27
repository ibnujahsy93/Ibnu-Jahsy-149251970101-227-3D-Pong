using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebLengthController : MonoBehaviour
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
                Debug.Log("p1 length Debuff");
                pad1.GetComponent<PaddleController>().ShrinkScale();
                manager.RemovePowerUp(gameObject);


            }
            else if (GameObject.Find("Ball(Clone)").GetComponent<BallController>().hitByPad2 == true)
            {
                Debug.Log("p2 length Debuff");
                pad2.GetComponent<BotHorizontalController>().ShrinkScale();
                manager.RemovePowerUp(gameObject);


            }
            else if (GameObject.Find("Ball(Clone)").GetComponent<BallController>().hitByPad3 == true)
            {
                Debug.Log("p3 length Debuff");
                pad3.GetComponent<BotVerticalController>().ShrinkScale();
                manager.RemovePowerUp(gameObject);


            }
            else if (GameObject.Find("Ball(Clone)").GetComponent<BallController>().hitByPad4 == true)
            {
                Debug.Log("p4 length Debuff");
                pad4.GetComponent<BotVerticalController2>().ShrinkScale();
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
