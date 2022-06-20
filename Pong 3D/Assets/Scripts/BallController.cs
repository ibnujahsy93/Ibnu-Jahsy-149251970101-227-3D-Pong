using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rBall;
    // Start is called before the first frame update
    void Start()
    {
        rBall = GetComponent<Rigidbody>();
        rBall.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
