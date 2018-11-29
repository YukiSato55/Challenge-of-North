using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTouch : MonoBehaviour {
    private float MoneyPercent;
    [SerializeField]
    private Button man, oku;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateDisplay(float Nowmoney, float Max)
    {
        Debug.Log("touch");
        MoneyPercent = Nowmoney / Max;
        if(MoneyPercent >= 0.6f)
        {
            oku.interactable = true;
            man.interactable = false;
        } else if(Nowmoney != 0)
        {
            oku.interactable = false;
            man.interactable = true;
        } else if(MoneyPercent == 0)
        {
            oku.interactable = false;
            man.interactable = false;
        }
        
    }
}
