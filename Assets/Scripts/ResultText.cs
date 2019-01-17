using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour {
    private Text maintext;

	// Use this for initialization
	void Start () {
        maintext = GetComponent<Text>();
        maintext.text = "全滅した...";
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void Clear()
    {
        maintext.text = "基地を破壊した!!";
    }
}
