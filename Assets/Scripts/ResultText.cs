using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour {
    private Text maintext;
    [SerializeField]
    private Text SubBreaktext, SubCosttext;

	// Use this for initialization
	void Start () {
        Debug.Log(SubCosttext + "" + SubBreaktext);
        maintext = GetComponent<Text>();
        maintext.text = "全滅した...";
        SubBreaktext.text = "0%";
        SubCosttext.text = "0/0";


    }
	
	// Update is called once per frame
	void Update () {

	}

    public void Clear(float NorumaCost)
    {
        maintext.text = "基地を破壊した!!";
        SubBreaktext.text = "100%";
        SubCosttext.text = GameObject.Find("SUMBuyMoney").GetComponent<SUMBuyMoney>().SUM + "/" + NorumaCost;
    }
}
