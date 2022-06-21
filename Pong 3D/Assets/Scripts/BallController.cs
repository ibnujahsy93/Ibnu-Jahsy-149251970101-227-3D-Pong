using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    public Vector3 resetPosition;
    public Rigidbody rBall;
    
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
        int randomValueX = Random.Range(2, 5);
        int randomValueZ = Random.Range(2, 5);

        rBall.velocity = new Vector3(randomValueX, 0, randomValueZ);
    }
    public void SpeedBall2()
    {
        rBall = GetComponent<Rigidbody>();
        int randomValueX = Random.Range(-2, -5);
        int randomValueZ = Random.Range(2, 5);

        rBall.velocity = new Vector3(randomValueX, 0, randomValueZ);
    }
    public void SpeedBall3()
    {
        rBall = GetComponent<Rigidbody>();
        int randomValueX = Random.Range(2, 5);
        int randomValueZ = Random.Range(-2, -5);

        rBall.velocity = new Vector3(randomValueX, 0, randomValueZ);
    }
    public void SpeedBall4()
    {
        rBall = GetComponent<Rigidbody>();
        int randomValueX = Random.Range(-2, -5);
        int randomValueZ = Random.Range(-2, -5);

        rBall.velocity = new Vector3(randomValueX, 0, randomValueZ);
    }



}
