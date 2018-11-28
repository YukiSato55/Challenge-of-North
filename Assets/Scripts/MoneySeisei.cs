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
    private GameObject gameObject;
    private float NowMoney = 0;
    private const int RESPAWN_TIME = 10;
    private MoneyManager moneyManager;
    private MoneyTouch moneyTouch;
    private DateTime LastTime;
    private string SaveName;

	// Use this for initialization
	void Start () {
        LastTime = DateTime.UtcNow;
        moneyManager = GameObject.Find("GameManager").GetComponent<MoneyManager>();
        moneyTouch = gameObject.GetComponent<MoneyTouch>();
        SaveName = name;
        Debug.Log(SaveName);
        if(PlayerPrefs.HasKey(SaveName))
        {
            NowMoney = PlayerPrefs.GetFloat(SaveName);
        } else
        {
            NowMoney = 0;
            PlayerPrefs.SetFloat(SaveName, NowMoney);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(NowMoney <= Max)
        {
            TimeSpan timeSpan = DateTime.UtcNow - LastTime; // 時差=現在-前回時刻
            if(timeSpan >= TimeSpan.FromSeconds(RESPAWN_TIME)) // 時差 >= RESPAWN_TIME
            {
                while(timeSpan >= TimeSpan.FromSeconds(RESPAWN_TIME))
                {
                    Form();
                    timeSpan -= TimeSpan.FromSeconds(RESPAWN_TIME);
                }
            }
        }
	}

    void Form()
    {
        NowMoney += FormMoney;
        moneyTouch.UpdateDisplay(NowMoney, Max);
        PlayerPrefs.SetFloat(SaveName, NowMoney);
    }

    public void GetMoney()
    {
        moneyManager.TouchGetMoney(NowMoney);
        NowMoney = 0;
        PlayerPrefs.SetFloat(SaveName, NowMoney);
    }
}
