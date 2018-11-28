﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyManager : MonoBehaviour {
    private float Money, MaxMoney;
    private MoneyGauge moneyGauge;
    [SerializeField]
    private GameObject MoneyGaugeSlider;

	// Use this for initialization
	void Awake () {

        moneyGauge = MoneyGaugeSlider.GetComponent<MoneyGauge>();
        if (PlayerPrefs.HasKey("Money")) // セーブデータ存在
        {
            Money = PlayerPrefs.GetFloat("Money");
            MaxMoney = PlayerPrefs.GetFloat("MaxMoney");
            //PlayerPrefs.SetInt("MaxMoney", MaxMoney);
        } else         // セーブデータ無
        {
            Money = 0;
            MaxMoney = 1000;
            PlayerPrefs.SetFloat ("Money", Money);
            PlayerPrefs.SetFloat("MaxMoney", MaxMoney);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TouchGetMoney(float GetMoney)
    {
        Money += GetMoney;
        if (Money > MaxMoney) Money = MaxMoney;
        PlayerPrefs.SetFloat("Money", Money);
        moneyGauge.UpDateGauge(100, 1);
    }

    public void UpGradeMaxMoney()
    {
        MaxMoney += 500;
        PlayerPrefs.SetFloat("MaxMoney", MaxMoney);
        moneyGauge.UpDateGauge(MaxMoney, 0);
    }

    public void BuyMons(float MonsPrice)
    {
        moneyGauge = MoneyGaugeSlider.GetComponent<MoneyGauge>();
        if (Money >= MonsPrice) //　買える
        {
            Money -= MonsPrice;
            // モンスターのカウント増加処理も書こう
        } else　　　　　　　　　// 買えない
        {
            Debug.Log("買えない");
        }
    }
}
