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
    [SerializeField]
    private GameObject Jihanki;
    private float NowMoney = 0;
    private const int ACTIVERESPAWN_TIME = 3;
    private const int UNDERRESPAWN_TIME = 15;
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
        //Debug.Log(SaveName);
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
            Debug.Log(timeSpan);                // オフラインから集計
            if (timeSpan >= TimeSpan.FromSeconds(UNDERRESPAWN_TIME)) // 時差 >= ACTIVERESPAWN_TIME
            {
                while (timeSpan >= TimeSpan.FromSeconds(UNDERRESPAWN_TIME) && NowMoney < Max)
                {
                    Debug.Log("uuum");
                    Form();
                    timeSpan -= TimeSpan.FromSeconds(UNDERRESPAWN_TIME);
                    //Debug.Log(timeSpan);
                    if (NowMoney == Max || timeSpan < TimeSpan.FromSeconds(UNDERRESPAWN_TIME)) break;
                }
            }
        }
        moneyTouch.UpdateDisplay(NowMoney, Max);
        LastTime = DateTime.UtcNow;
    }
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(gameObject.name + ":" + NowMoney);

        TimeSpan timeSpan = DateTime.UtcNow - LastTime; // 時差=現在-前回時刻
        if (timeSpan >= TimeSpan.FromSeconds(ACTIVERESPAWN_TIME)) // 時差 >= ACTIVERESPAWN_TIME
        {
            LastTime = DateTime.UtcNow;
            PlayerPrefs.SetString("LastTime", LastTime.ToBinary().ToString());
            if (NowMoney < Max) //テナントがいっぱいじゃないとき
                {
                Form();
                timeSpan -= TimeSpan.FromSeconds(ACTIVERESPAWN_TIME);
            }
          
        }
        
	}

    void Form()
    {
        Debug.Log("増えたで" + NowMoney + " + " + FormMoney);
        NowMoney += FormMoney;
        if (NowMoney > Max) NowMoney = Max;
        moneyTouch.UpdateDisplay(NowMoney, Max);
        PlayerPrefs.SetFloat(SaveName, NowMoney);
    }

    public void GetMoney()
    {
        moneyManager.TouchGetMoney(NowMoney);
        NowMoney = 0;
        moneyTouch.Touch();
        PlayerPrefs.SetFloat(SaveName, NowMoney);
    }

    public void JihankiTouchGet()
    {
        float Money = Mathf.Round(UnityEngine.Random.Range(0.0f, 5.9f));
        if (Money >= 1)
        {
            moneyManager.TouchGetMoney(Money);
        }
    }
}
