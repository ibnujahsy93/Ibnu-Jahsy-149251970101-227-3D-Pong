using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public int spawnInterval;
    public int ballCount;
    private float timer;
    public BallController ballSpeed;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            if (ballCount < 5)
            {
                SpawnBall();
                timer -= spawnInterval;
            }
        }
        
        
    }

    public void SpawnBall()
    {      
        Instantiate(ballPrefab, GenerateSpawnPosition(), ballPrefab.transform.rotation);
        ballCount++;



    }

    private Vector3 GenerateSpawnPosition()
    {
        int randomNumber = Random.Range(1, 4);
        if (randomNumber == 1)
        {
            Vector3 randomPos = new Vector3(-3.9f, 0.2f, -4.12f);
            
            return randomPos;
        }
        else if(randomNumber == 2)
        {
            Vector3 randomPos = new Vector3(3.9f, 0.2f, -4.12f);
            
            return randomPos;
        }
        else if (randomNumber == 3)
        {
            Vector3 randomPos = new Vector3(-3.9f, 0.2f, 4.12f);
            
            return randomPos;
        }
        else if (randomNumber == 4)
        {
            Vector3 randomPos = new Vector3(3.9f, 0.2f, 4.12f);
            
            return randomPos;
        }
        return Vector3.zero;
        
    }

}
