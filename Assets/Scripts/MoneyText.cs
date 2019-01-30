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
        phase = STAY;
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
                            if (Money >= MaxMoney)
                            {
                                Money = MaxMoney;
                                checkflug = false;
                                break;
                            }
                            Money += 1;
                            nowmoney -= 1;
                            if (nowmoney <= 0)
                            {
                                checkflug = false;
                                break;
                            }
                            break;
                        default:
                            if (Money >= MaxMoney)
                            {
                                Money = MaxMoney;
                                checkflug = false;
                                break;
                            }
                            Money += 10;
                            nowmoney -= 10;
                            if(nowmoney <= 0)
                            {
                                checkflug = false;
                                break;
                            }
                            
                            break;
                    }
                    Debug.Log("text" + Money);
                    text.text = "資金：" + Money + "/" + MaxMoney;
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
            case 0: // 最大値アップ
                MaxMoney = money;
                break;

            case 1: // お金回収
                nowmoney = money;
                phase = PLUS_MONEY;
                checkflug = true;
                break;
        }
    }
}
