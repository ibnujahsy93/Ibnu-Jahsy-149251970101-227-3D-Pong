using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text p1;
    public Text p2;
    public Text p3;
    public Text p4;

    public ScoreManager manager;

    private void Update()
    {
        p1.text = manager.p1Score.ToString();
        p2.text = manager.p2Score.ToString();
        p3.text = manager.p3Score.ToString();
        p4.text = manager.p4Score.ToString();
    }
}
