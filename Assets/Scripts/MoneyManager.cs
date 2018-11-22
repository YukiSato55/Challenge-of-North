using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyManager : MonoBehaviour {
    private int Money, MaxMoney;
    private MoneyGauge moneyGauge;
    [SerializeField]
    private GameObject MoneyGaugeSlider;

	// Use this for initialization
	void Awake () {

        moneyGauge = MoneyGaugeSlider.GetComponent<MoneyGauge>();
        if (PlayerPrefs.HasKey("Money")) // セーブデータ存在
        {
            Money = PlayerPrefs.GetInt("Money");
            MaxMoney = PlayerPrefs.GetInt("MaxMoney");
            //PlayerPrefs.SetInt("MaxMoney", MaxMoney);
        } else         // セーブデータ無
        {
            Money = 0;
            MaxMoney = 1000;
            PlayerPrefs.SetInt("Money", Money);
            PlayerPrefs.SetInt("MaxMoney", MaxMoney);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TouchGetMoney(int GetMoney)
    {
        Debug.Log("ugoita");
        Money += 100;
        if (Money > MaxMoney) Money = MaxMoney;
        PlayerPrefs.SetInt("Money", Money);
        moneyGauge.UpDateGauge(100, 1);
    }

    public void UpGradeMaxMoney()
    {
        MaxMoney += 500;
        PlayerPrefs.SetInt("MaxMoney", MaxMoney);
        moneyGauge.UpDateGauge(MaxMoney, 0);
    }

    public void BuyMons(int MonsPrice)
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
