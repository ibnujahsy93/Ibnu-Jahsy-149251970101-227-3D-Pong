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

    public List<Vector3> spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            if (ballCount < 5)
            {
                SpawnBall(spawnPoint[Random.Range(0, spawnPoint.Count - 1)]);
                timer -= spawnInterval;
            }
        }
        
        
    }

    public void SpawnBall(Vector3 pos)
    {      
        Instantiate(ballPrefab, pos, ballPrefab.transform.rotation);
        ballCount++;

    }

}
