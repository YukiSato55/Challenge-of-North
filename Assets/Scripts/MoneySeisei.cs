using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MoneySeisei : MonoBehaviour {
    [SerializeField]
    //[Range(0, 1)]
    private float FormMoney, Max;
    [SerializeField]
    private GameObject Tenant;
    private float NowMoney = 0;
    private const int RESPAWN_TIME = 5;
    private MoneyManager moneyManager;
    private MoneyTouch moneyTouch;
    private DateTime LastTime;
    private string SaveName;

	// Use this for initialization
	void Start () {

        //最終起動時間取得
        if (PlayerPrefs.HasKey("LastTime"))
        {
            string time = PlayerPrefs.GetString("LastTime");
            long temp = Convert.ToInt64(time);
            LastTime = DateTime.FromBinary(temp);
        }
        else
        {
            LastTime = DateTime.UtcNow;
            PlayerPrefs.SetString("LastTime", LastTime.ToBinary().ToString());
        }

        //テナントごとの直近の保持金額ロード
        SaveName = name;
        Debug.Log(SaveName);
        if (PlayerPrefs.HasKey(SaveName))
        {
            NowMoney = PlayerPrefs.GetFloat(SaveName);
        }
        else
        {
            NowMoney = 0;
            PlayerPrefs.SetFloat(SaveName, NowMoney);
        }

        moneyManager = GameObject.Find("GameManager").GetComponent<MoneyManager>();
        moneyTouch = Tenant.GetComponent<MoneyTouch>();


        if (NowMoney < Max) //テナントがいっぱいじゃないとき
        {
            TimeSpan timeSpan = DateTime.UtcNow - LastTime; // 時差=現在-前回時刻
            if (timeSpan >= TimeSpan.FromSeconds(RESPAWN_TIME)) // 時差 >= RESPAWN_TIME
            {
                while (timeSpan >= TimeSpan.FromSeconds(RESPAWN_TIME) && NowMoney < Max)
                {
                    Form();
                    timeSpan -= TimeSpan.FromSeconds(RESPAWN_TIME);
                    if (NowMoney == Max || timeSpan < TimeSpan.FromSeconds(RESPAWN_TIME)) break;
                }
            }
        }
        LastTime = DateTime.UtcNow;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(NowMoney);

        TimeSpan timeSpan = DateTime.UtcNow - LastTime; // 時差=現在-前回時刻
            //Debug.Log(timeSpan);
        if (timeSpan >= TimeSpan.FromSeconds(RESPAWN_TIME)) // 時差 >= RESPAWN_TIME
        {
            LastTime = DateTime.UtcNow;
            PlayerPrefs.SetString("LastTime", LastTime.ToBinary().ToString());
            if (NowMoney < Max) //テナントがいっぱいじゃないとき
                {
                Form();
                timeSpan -= TimeSpan.FromSeconds(RESPAWN_TIME);
                //Debug.Log(Tenant + ":" + timeSpan + " >= " + TimeSpan.FromSeconds(RESPAWN_TIME));
            }
          
        }
        
	}

    void Form()
    {
        NowMoney += FormMoney;
        if (NowMoney > Max) NowMoney = Max;
        Debug.Log("生成");

        moneyTouch.UpdateDisplay(NowMoney, Max);
        //PlayerPrefs.SetFloat(SaveName, NowMoney);
    }

    public void GetMoney()
    {
        moneyManager.TouchGetMoney(NowMoney);
        NowMoney = 0;
        moneyTouch.UpdateDisplay(NowMoney, Max);
        //PlayerPrefs.SetFloat(SaveName, NowMoney);
    }
}
