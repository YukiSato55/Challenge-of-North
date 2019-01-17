using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyGauge : MonoBehaviour {
    private float MoneyValue, nowmoney;
    private int onePlus; // ゲージの1フレーム増加量管理
    private MoneyManager moneyManager;
    private Slider slider;
    private bool checkflug;

    const int PLUS_MONEY = 1;
    const int STAY = 0;
    private int phase;

	// Use this for initialization
	void Start () {
        //moneyManager = GameObject.Find("GameManager").GetComponent<MoneyManager>();
        slider = GetComponent<Slider>();
        phase = STAY;
        slider.maxValue = PlayerPrefs.GetFloat("MaxMoney");
        //slider.value = PlayerPrefs.GetFloat("Money");
        nowmoney = PlayerPrefs.GetFloat("Money");

        checkflug = false;

    }
	
	// Update is called once per frame
	void Update () {
		switch(phase)
        {
            case PLUS_MONEY:
                if (checkflug) {
                    onePlus = (int)(nowmoney / 10);
                    switch (onePlus) {
                        case 0:
                            slider.value += 1f;
                            nowmoney -= 1f;
                            if (nowmoney <= 0) checkflug = false;
                            break;
                        default:
                            slider.value += 10f;
                            nowmoney -= 10f;
                            if (nowmoney <= 0) checkflug = false;
                            break;
                    }
                } else
                {
                    checkflug = false;
                    phase = STAY;
                }
                break;
            
        }
	}

    public void UpDateGauge(float money, int Update) // お金ゲージ更新処理
    {                             //０：最大値　１：お金ゲット
        float moneyval = money;
        switch(Update)
        {
            case 0:
                slider.maxValue = moneyval;
                break;

            case 1:
                nowmoney = moneyval;
                phase = PLUS_MONEY;
                checkflug = true;
                break;
        }
    }
}
