using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTouch : MonoBehaviour {
    private float MoneyPercent;
    private 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateDisplay(float Nowmoney, float Max)
    {
        MoneyPercent = Nowmoney / Max;
        if(MoneyPercent >= 0.6f)
        {

        } else if(Nowmoney != 0)
        {

        } else
        {

        }
    }
}
