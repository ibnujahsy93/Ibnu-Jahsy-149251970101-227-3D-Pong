using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UltBarController : MonoBehaviour
{
    private Ultimate ultimate;
    public KeyCode ultKey1;
    public KeyCode ultKey2;
    public KeyCode ultKey3;
    public KeyCode ultKey4;
    public Collider pad1;
    public Collider pad2;
    public Collider pad3;
    public Collider pad4;


    private Image barImage1;
    private Image barImage2;
    private Image barImage3;
    private Image barImage4;
    private void Awake()
    {
        barImage1 = transform.Find("BarUlt1").GetComponent<Image>();
        barImage2 = transform.Find("BarUlt2").GetComponent<Image>();
        barImage3 = transform.Find("BarUlt3").GetComponent<Image>();
        barImage4 = transform.Find("BarUlt4").GetComponent<Image>();
        ultimate = new Ultimate();
        
    }
    private void Update()
    {
        ultimate.Update();

        barImage1.fillAmount = ultimate.GetUltNormalized1();
        barImage2.fillAmount = ultimate.GetUltNormalized2();
        barImage3.fillAmount = ultimate.GetUltNormalized3();
        barImage4.fillAmount = ultimate.GetUltNormalized4();

        if (Input.GetKeyDown(ultKey1) && ultimate.ultAmount1 == 100)
        {
            ultimate.UsingUlt1(100);
            pad1.GetComponent<PaddleController>().ActivateSpeedPower();
            pad1.GetComponent<PaddleController>().DoubleScale();
        }
        else if (Input.GetKeyDown(ultKey2) && ultimate.ultAmount2 == 100)
        {
            ultimate.UsingUlt2(100);
            pad2.GetComponent<PaddleController>().ActivateSpeedPower();
            pad2.GetComponent<PaddleController>().DoubleScale();
        }
        else if (Input.GetKeyDown(ultKey3) && ultimate.ultAmount3 == 100)
        {
            ultimate.UsingUlt3(100);
            pad3.GetComponent<PaddleController>().ActivateSpeedPower();
            pad3.GetComponent<PaddleController>().DoubleScale();
        }
        else if (Input.GetKeyDown(ultKey4) && ultimate.ultAmount4 == 100)
        {
            ultimate.UsingUlt4(100);
            pad4.GetComponent<PaddleController>().ActivateSpeedPower();
            pad4.GetComponent<PaddleController>().DoubleScale();
        }
        
        if (ultimate.ultAmount2 == 100 && pad2.GetComponent<BotHorizontalController>().isBot == true)
        {
            ultimate.UsingUlt2(100);
            pad2.GetComponent<BotHorizontalController>().ActivateSpeedPower();
            pad2.GetComponent<BotHorizontalController>().DoubleScale();
        }
        
        else if (ultimate.ultAmount3 == 100 && pad3.GetComponent<BotVerticalController>().isBot == true)
        {
            ultimate.UsingUlt3(100);
            pad3.GetComponent<BotVerticalController>().ActivateSpeedPower();
            pad3.GetComponent<BotVerticalController>().DoubleScale();
        }
        
        else if (ultimate.ultAmount4 == 100 && pad4.GetComponent<BotVerticalController2>().isBot == true)
        {
            ultimate.UsingUlt4(100);
            pad4.GetComponent<BotVerticalController2>().ActivateSpeedPower();
            pad4.GetComponent<BotVerticalController2>().DoubleScale();

        }
    }


    public class Ultimate
    {
        public const int ultMax = 100;

        public float ultAmount1;
        public float ultAmount2;
        public float ultAmount3;
        public float ultAmount4;
        private float ultRegen;

        public Ultimate()
        {
            ultAmount1 = 0;
            ultAmount2 = 0;
            ultAmount3 = 0;
            ultAmount4 = 0;
            ultRegen = 5f;
        }
        
        public void Update()
        {
            ultAmount1 += ultRegen * Time.deltaTime;
            ultAmount1 = Mathf.Clamp(ultAmount1, 0f, ultMax);
            ultAmount2 += ultRegen * Time.deltaTime;
            ultAmount2 = Mathf.Clamp(ultAmount2, 0f, ultMax);
            ultAmount3 += ultRegen * Time.deltaTime;
            ultAmount3 = Mathf.Clamp(ultAmount3, 0f, ultMax);
            ultAmount4 += ultRegen * Time.deltaTime;
            ultAmount4 = Mathf.Clamp(ultAmount4, 0f, ultMax);
        }

        public void UsingUlt1(int amount)
        {
            if (ultAmount1 >= amount)
            {
                ultAmount1 -= amount;
            }
        }
        public void UsingUlt2(int amount)
        {
            if (ultAmount2 >= amount)
            {
                ultAmount2 -= amount;
            }
        }
        public void UsingUlt3(int amount)
        {
            if (ultAmount3 >= amount)
            {
                ultAmount3 -= amount;
            }
        }
        public void UsingUlt4(int amount)
        {
            if (ultAmount4 >= amount)
            {
                ultAmount4 -= amount;
            }
        }

        public float GetUltNormalized1()
        {
            return ultAmount1 / ultMax;
        }
        public float GetUltNormalized2()
        {
            return ultAmount2 / ultMax;
        }
        public float GetUltNormalized3()
        {
            return ultAmount3 / ultMax;
        }
        public float GetUltNormalized4()
        {
            return ultAmount4 / ultMax;
        }
    }
}
