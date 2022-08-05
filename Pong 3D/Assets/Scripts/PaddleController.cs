using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode upKey;
    public KeyCode downKey;
    private float timer;
    private float timer2;
    private Rigidbody rigPaddle;
    public bool isBot;
    public Transform ball;
    public int randomNumber;
    public bool moveLeft;
    




    // Start is called before the first frame update
    void Start()
    {
        
        rigPaddle = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(1, 3);
        MoveObject(GetInput());
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            NormalSpeed();
            timer = 0;
            
        }

        if (timer2 > 0)
        {
            timer2 -= Time.deltaTime;
        }
        else
        {
            NormalScale();
            timer2 = 0;

        }

    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
        else if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        else if (Input.GetKey(upKey))
        {
            return Vector3.forward * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector3.back * speed;
        }

        return Vector3.zero;
    }

   

    private Vector3 BotMovement()
    {
        
        if (randomNumber == 1)
        {
            moveLeft = true;
            
            return Vector3.left * speed;
        }
        else if (randomNumber == 2)
        {
            moveLeft = false;
            
            return Vector3.right * speed;
        }

        if (moveLeft == true)
        {
            if (transform.position.x < -1)
            {
                moveLeft = false;
                Debug.Log("tes kiri");
                
                return Vector3.right * speed;
            }
        }
        else if (moveLeft == false)
        {
            if (transform.position.x > 1)
            {
                moveLeft = true;
                Debug.Log("tes kanan");

                return Vector3.left * speed;
            }
        }



        return Vector3.zero;
    }
    
   
    

    private void MoveObject(Vector3 movement)
    {
        rigPaddle.velocity = movement;
    }

    public void ActivateSpeedPower()
    {
        speed *= 1.5f;
        timer = 5;
    }
    public void NormalSpeed()
    {
        speed = 3;
    }
    public void ActivateSlowSpeed()
    {
        speed *= 0.5f;
        timer = 5;
    }

    public void NormalScale()
    {
        transform.localScale = new Vector3(2, 0.2f, 0.3f);
    }
    public void DoubleScale()
    {
        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y, transform.localScale.z);
        timer2 = 5;
    }
    public void ShrinkScale()
    {
        transform.localScale = new Vector3(transform.localScale.x * 0.8f, transform.localScale.y, transform.localScale.z);
        timer2 = 5;
    }
}
