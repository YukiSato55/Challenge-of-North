using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyManager : MonoBehaviour {
    private float Money, MaxMoney;
    private MoneyGauge moneyGauge;
    private MoneyText moneyText;
    [SerializeField]
    private GameObject MoneyGaugeSlider, MoneyGaugeText;

	// Use this for initialization
	void Awake () {

        moneyGauge = MoneyGaugeSlider.GetComponent<MoneyGauge>();
        moneyText = MoneyGaugeText.GetComponent<MoneyText>();
        if (PlayerPrefs.HasKey("Money")) // セーブデータ存在
        {
            Money = PlayerPrefs.GetFloat("Money");
            MaxMoney = PlayerPrefs.GetFloat("MaxMoney");
            //PlayerPrefs.SetInt("MaxMoney", MaxMoney);
        } else         // セーブデータ無
        {
            Money = 0;
            MaxMoney = 5000;
            PlayerPrefs.SetFloat ("Money", Money);
            PlayerPrefs.SetFloat("MaxMoney", MaxMoney);
        }
        moneyGauge.UpDateGauge(Money, 1);
        moneyText.UpDateText((int)Money, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TouchGetMoney(float GetMoney)
    {
        //Debug.Log("今" + Money);
        //Debug.Log("増" + GetMoney);
        Money += GetMoney;
        //Debug.Log("結果" + Money);
        if (Money > MaxMoney) Money = MaxMoney;
        //PlayerPrefs.SetFloat("Money", Money);
        moneyGauge.UpDateGauge(GetMoney, 1);
        moneyText.UpDateText((int)GetMoney, 1);
        PlayerPrefs.SetFloat ("Money", Money);
    }

    public void UpGradeMaxMoney()
    {
        MaxMoney += 500;
        PlayerPrefs.SetFloat("MaxMoney", MaxMoney);
        moneyGauge.UpDateGauge(MaxMoney, 0);
        moneyText.UpDateText((int)MaxMoney, 0);
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
