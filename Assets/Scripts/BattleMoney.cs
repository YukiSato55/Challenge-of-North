using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMoney : MonoBehaviour {
    private Text MoneyText;
    private float nowMoney, textmoney;
    private StatusDataBase statusData;
    private SUMBuyMoney SUM;

	// Use this for initialization
	void Start () {
        statusData = GameObject.Find("MonsStatusDatabase").GetComponent<StatusDataBase>();
        SUM = GameObject.Find("SUMBuyMoney").GetComponent<SUMBuyMoney>();
        MoneyText = GetComponent<Text>();
		if(PlayerPrefs.HasKey("Money"))
        {
            nowMoney = PlayerPrefs.GetFloat("Money");
        } else
        {
            nowMoney = 0;
        }
        textmoney = nowMoney;
         MoneyText.text = "所持金:￥" + textmoney;
	}
	
	// Update is called once per frame
	void Update () {
		if(nowMoney != textmoney)
        {
            textmoney--;
            MoneyText.text = "所持金:￥" + textmoney;
        }
	}

    public bool BuyMons(int monsID, bool Check)
    {
        int Rank;
        float cost;
        if (PlayerPrefs.HasKey("MonsRank_" + monsID))
        {
            Rank = PlayerPrefs.GetInt("MonsRank_" + monsID);
        } else
        {
            Rank = 0;
            PlayerPrefs.SetInt("MonsRank_" + monsID, Rank);
        }
        cost = statusData.MonsDataMani[monsID, Rank];

        if ((nowMoney - cost) >= 0)
        {
            nowMoney -= cost;
            PlayerPrefs.SetFloat("Money", nowMoney);
            SUM.SUMMoney(cost);
            Check = true;
        } else
        {
            Debug.Log("買えへん");
            Check = false;
        }
        return Check;
    }
}
