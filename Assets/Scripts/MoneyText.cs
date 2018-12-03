using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour {
    private Text text;
    private int Money, MaxMoney, nowmoney, phase, onePlus;
    private bool checkflug;

    const int PLUS_MONEY = 1;
    const int STAY = 0;


	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        Money = (int)PlayerPrefs.GetFloat("Money");
        MaxMoney = (int)PlayerPrefs.GetFloat("MaxMoney");
        
        text.text = "資金：" + Money + "/" + MaxMoney;
    }
	
	// Update is called once per frame
	void Update () {
        switch (phase)
        {
            case PLUS_MONEY:
                if (checkflug)
                {
                    onePlus = nowmoney / 10;
                    switch (onePlus)
                    {
                        case 0:
                            Money += 1;
                            nowmoney -= 1;
                            if (nowmoney == 0) checkflug = false;
                            break;
                        default:
                            Money += 10;
                            nowmoney -= 10;
                            if (nowmoney == 0) checkflug = false;
                            break;
                    }
                    if (Money > MaxMoney)
                    {
                        text.text = "資金：" + MaxMoney + "/" + MaxMoney;
                    } else
                    {
                        text.text = "資金：" + Money + "/" + MaxMoney;
                    }
                }
                else
                {
                    checkflug = false;
                    phase = STAY;
                }
                break;

        }
    }

    public void UpDateText(int money, int Update) // お金ゲージ更新処理
    {                             //０：最大値　１：お金ゲット
        switch (Update)
        {
            case 0:
                MaxMoney = money;
                break;

            case 1:
                nowmoney = money;
                phase = PLUS_MONEY;
                checkflug = true;
                break;
        }
    }
}
