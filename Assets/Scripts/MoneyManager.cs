using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour {
    private int Money, MaxMoney;
    private MoneyGauge moneyGauge;
    [SerializeField]
    private GameObject MoneyGaugeSlider;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("Money"))
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
        moneyGauge = MoneyGaugeSlider.GetComponent<MoneyGauge>();
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
}
