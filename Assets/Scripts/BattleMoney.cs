using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMoney : MonoBehaviour {
    private Text MoneyText;
    private float nowMoney;

	// Use this for initialization
	void Start () {
        MoneyText = GetComponent<Text>();
		if(PlayerPrefs.HasKey("Money"))
        {
            nowMoney = PlayerPrefs.GetFloat("Money");
        } else
        {
            nowMoney = 0;
        }
        MoneyText.text = "所持金:￥" + nowMoney;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
