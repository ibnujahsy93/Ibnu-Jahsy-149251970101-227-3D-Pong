using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotVerticalController2 : MonoBehaviour
{
    private float waitBeforeMoving = 0.1f;
    private bool hasArrived = false;
    private float movementDuration = 1.0f;
    public bool isBot;
    public float speed;
    private float timer;
    private float timer2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

        if (isBot == true)
        {
            if (!hasArrived)
            {
                hasArrived = true;
                float randZ = Random.Range(-2.0f, 2.0f);

                StartCoroutine(MoveToPoint(new Vector3(4, 0, randZ)));
            }
        }

    }
    public void ActivateSpeedPower()
    {
        movementDuration = 0.5f;
        timer = 5;
    }
    public void NormalSpeed()
    {
        movementDuration = 1.0f;
    }
    public void ActivateSlowSpeed()
    {
        movementDuration = 1.5f;
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


    private IEnumerator MoveToPoint(Vector3 targetPos)
    {
        float timer3 = 0.0f;
        Vector3 startPos = transform.position;

        while (timer3 < movementDuration)
        {
            timer3 += Time.deltaTime;
            float t = timer3 / movementDuration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            transform.position = Vector3.Lerp(startPos, targetPos, t);

            yield return null;
        }

        yield return new WaitForSeconds(waitBeforeMoving);
        hasArrived = false;
    }


}
