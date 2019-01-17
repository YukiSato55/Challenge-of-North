using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaColor : MonoBehaviour {
    [SerializeField]
    private Image gauge;
    float a_color;

    [SerializeField]
    private float totalTime, SaveTotalTime;
    private int seconds;

    private Color color;
    float red, green, blue;
    // Use this for initialization
    void Start () {
        a_color = GetComponent<Image>().color.a;
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
        SaveTotalTime = totalTime; // 保存用
    }

    // Update is called once per frame
    void Update()
    {
        
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;

        if(totalTime < 0)
        {
            totalTime = 0;
        }

        //テキストの透明度を変更する
        if (seconds == 0)
        {
            a_color -= 0.01f;
            GetComponent<Image>().color = new Color(red, green, blue, a_color);

            //透明度が0になったら終了する。
            if (a_color < 0)
            {
                a_color = 0;
            }
        }
        //if(Damage食らった判定)
        //a_color = 1
        //totalTime = SaveTotalTime;
    }

    public void Reset()
    {
        a_color = 1;
        totalTime = SaveTotalTime;
        GetComponent<Image>().color = new Color(red, green, blue, a_color);
    }
}
