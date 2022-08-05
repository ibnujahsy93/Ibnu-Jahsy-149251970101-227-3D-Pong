using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarController : MonoBehaviour
{
    private HpBar hpBar;
    
    public ScoreManager manager;

    private Image hpImage1;
    private Image hpImage2;
    private Image hpImage3;
    private Image hpImage4;

    private void Awake()
    {
        hpImage1 = transform.Find("BarHp1").GetComponent<Image>();
        hpImage2 = transform.Find("BarHp2").GetComponent<Image>();
        hpImage3 = transform.Find("BarHp3").GetComponent<Image>();
        hpImage4 = transform.Find("BarHp4").GetComponent<Image>();
        hpBar = new HpBar();

    }
    private void Update()
    {
        hpImage1.fillAmount = hpBar.GetHpNormalized1();
        hpImage2.fillAmount = hpBar.GetHpNormalized2();
        hpImage3.fillAmount = hpBar.GetHpNormalized3();
        hpImage4.fillAmount = hpBar.GetHpNormalized4();

        if (manager.p1Score == 1 && hpBar.hpAmount1 == 100)
        {
            hpBar.DecreaseHp1(25);
        }
        else if(manager.p1Score == 2 && hpBar.hpAmount1 == 75)
        {
            hpBar.DecreaseHp1(25);
        }
        else if (manager.p1Score == 3 && hpBar.hpAmount1 == 50)
        {
            hpBar.DecreaseHp1(25);
        }
        else if (manager.p1Score == 4 && hpBar.hpAmount1 == 25)
        {
            hpBar.DecreaseHp1(25);
        }

        
        else if (manager.p2Score == 1 && hpBar.hpAmount2 == 100)
        {
            hpBar.DecreaseHp2(25);
        }
        else if (manager.p2Score == 2 && hpBar.hpAmount2 == 75)
        {
            hpBar.DecreaseHp2(25);
        }
        else if (manager.p2Score == 3 && hpBar.hpAmount2 == 50)
        {
            hpBar.DecreaseHp2(25);
        }
        else if (manager.p2Score == 4 && hpBar.hpAmount2 == 25)
        {
            hpBar.DecreaseHp2(25);
        }

        
        else if (manager.p3Score == 1 && hpBar.hpAmount3 == 100)
        {
            hpBar.DecreaseHp3(25);
        }
        else if (manager.p3Score == 2 && hpBar.hpAmount3 == 75)
        {
            hpBar.DecreaseHp3(25);
        }
        else if (manager.p3Score == 3 && hpBar.hpAmount3 == 50)
        {
            hpBar.DecreaseHp3(25);
        }
        else if (manager.p3Score == 4 && hpBar.hpAmount3 == 25)
        {
            hpBar.DecreaseHp3(25);
        }

        
        else if (manager.p4Score == 1 && hpBar.hpAmount4 == 100)
        {
            hpBar.DecreaseHp4(25);
        }
        else if (manager.p4Score == 2 && hpBar.hpAmount4 == 75)
        {
            hpBar.DecreaseHp4(25);
        }
        else if (manager.p4Score == 3 && hpBar.hpAmount4 == 50)
        {
            hpBar.DecreaseHp4(25);
        }
        else if (manager.p4Score == 4 && hpBar.hpAmount4 == 25)
        {
            hpBar.DecreaseHp4(25);
        }


    }



    public class HpBar
    {
        public const int HpMax = 100;

        public float hpAmount1;
        public float hpAmount2;
        public float hpAmount3;
        public float hpAmount4;


        public HpBar()
        {
            hpAmount1 = 100;
            hpAmount2 = 100;
            hpAmount3 = 100;
            hpAmount4 = 100;

        }

        public void Update()
        {
            
            hpAmount1 = Mathf.Clamp(hpAmount1, 0f, HpMax);
            hpAmount2 = Mathf.Clamp(hpAmount1, 0f, HpMax);
            hpAmount3 = Mathf.Clamp(hpAmount1, 0f, HpMax);
            hpAmount4 = Mathf.Clamp(hpAmount1, 0f, HpMax);
        }
        public void DecreaseHp1(int amount)
        {
            if (hpAmount1 >= amount)
            {
                hpAmount1 -= amount;
            }
        }
        public void DecreaseHp2(int amount)
        {
            if (hpAmount2 >= amount)
            {
                hpAmount2 -= amount;
            }
        }
        public void DecreaseHp3(int amount)
        {
            if (hpAmount3 >= amount)
            {
                hpAmount3 -= amount;
            }
        }
        public void DecreaseHp4(int amount)
        {
            if (hpAmount4 >= amount)
            {
                hpAmount4 -= amount;
            }
        }



        public float GetHpNormalized1()
        {
            return hpAmount1 / HpMax;
        }
        public float GetHpNormalized2()
        {
            return hpAmount2 / HpMax;
        }
        public float GetHpNormalized3()
        {
            return hpAmount3 / HpMax;
        }
        public float GetHpNormalized4()
        {
            return hpAmount4 / HpMax;
        }
    }

}
