using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SUMMoneyText : MonoBehaviour {
    private Text text;
    private float Money;
    [SerializeField]
    private SUMBuyMoney SUM;

	// Use this for initialization
	void Awake () {
        //SUM = GameObject.Find("SUMBuyMoney").GetComponent<SUMBuyMoney>();
        text = GetComponent<Text>();
        text.text = ""+Money;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Upsum()
    {
        Debug.Log(SUM);
        float sum = SUM.Return();
        text.text = "" + sum;
    }
}
