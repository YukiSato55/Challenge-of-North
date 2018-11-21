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
	void Start () {
        if (SceneManager.GetActiveScene().name == "home")
        {
            moneyGauge = MoneyGaugeSlider.GetComponent<MoneyGauge>();
        }
        if (PlayerPrefs.HasKey("Money"))
        {
            Money = PlayerPrefs.GetInt("Money");
            MaxMoney = PlayerPrefs.GetInt("MaxMoney");
            PlayerPrefs.SetInt("MaxMoney", MaxMoney);
        } else
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
        Money += GetMoney;
        if (Money > MaxMoney) Money = MaxMoney;
        PlayerPrefs.SetInt("Money", Money);
        moneyGauge.UpDateGauge();
    }

    public void UpGradeMaxMoney()
    {
        MaxMoney += 500;
        PlayerPrefs.SetInt("MaxMoney", MaxMoney);
    }

    public void BuyMons(int MonsPrice)
    {
        moneyGauge = MoneyGaugeSlider.GetComponent<MoneyGauge>();
        if (Money >= MonsPrice) //　買える
        {
            Money -= MonsPrice;
        } else　　　　　　　　　// 買えない
        {

        }
    }
}
