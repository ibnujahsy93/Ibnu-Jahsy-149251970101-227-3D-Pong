using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    public Vector3 resetPosition;
    public Rigidbody rBall;
    public bool hitByPad1;
    public bool hitByPad2;
    public bool hitByPad3;
    public bool hitByPad4;
    public int randomValueX;
    public int randomValueZ;
    

    // Start is called before the first frame update
    void Start()
    {
        ResetBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBall()
    {
        
        if (transform.position == new Vector3(-3.9f, 0.2f, -4.12f))
        {
            SpeedBall1();
        }
        else if (transform.position == new Vector3(3.9f, 0.2f, -4.12f))
        {
            SpeedBall2();
        }
        else if (transform.position == new Vector3(-3.9f, 0.2f, 4.12f))
        {
            SpeedBall3();
        }
        else if (transform.position == new Vector3(3.9f, 0.2f, 4.12f))
        {
            SpeedBall4();
        }

    }
    public void SpeedBall1()
    {
        rBall = GetComponent<Rigidbody>();
        randomValueX = Random.Range(3, 7);
        randomValueZ = Random.Range(3, 7);

        rBall.velocity = new Vector3(randomValueX, 0, randomValueZ);
    }
    public void SpeedBall2()
    {
        rBall = GetComponent<Rigidbody>();
        randomValueX = Random.Range(-3, -7);
        randomValueZ = Random.Range(3, 7);

        rBall.velocity = new Vector3(randomValueX, 0, randomValueZ);
    }
    public void SpeedBall3()
    {
        rBall = GetComponent<Rigidbody>();
        randomValueX = Random.Range(3, 7);
        randomValueZ = Random.Range(-3, -7);

        rBall.velocity = new Vector3(randomValueX, 0, randomValueZ);
    }
    public void SpeedBall4()
    {
        rBall = GetComponent<Rigidbody>();
        randomValueX = Random.Range(-3, -7);
        randomValueZ = Random.Range(-3, -7);

        rBall.velocity = new Vector3(randomValueX, 0, randomValueZ);
    }

    public void ActivateSpeedPower(float magnitude)
    {

        rBall = GetComponent<Rigidbody>();
        randomValueX = Random.Range(-2, 5);
        randomValueZ = Random.Range(-2, 5);

        rBall.velocity = new Vector3(randomValueX * magnitude, 0, randomValueZ * magnitude);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pad1")
        {
            hitByPad1 = true;
            hitByPad2 = false;
            hitByPad3 = false;
            hitByPad4 = false;
        }
        else if (collision.gameObject.tag == "Pad2")
        {
            hitByPad1 = false;
            hitByPad2 = true;
            hitByPad3 = false;
            hitByPad4 = false;
        }
        else if (collision.gameObject.tag == "Pad3")
        {
            hitByPad1 = false;
            hitByPad2 = false;
            hitByPad3 = true;
            hitByPad4 = false;
        }
        else if (collision.gameObject.tag == "Pad4")
        {
            hitByPad1 = false;
            hitByPad2 = false;
            hitByPad3 = false;
            hitByPad4 = true;
        }
    }



}
