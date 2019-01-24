using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakPercent : MonoBehaviour {
    private int breakpoint;
    private Text text;

	// Use this for initialization
	void Awake () {
        text = GetComponent<Text>();
        breakpoint = 0;
        text.text = ""+breakpoint;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckPoint(float Percent)
    {
        breakpoint = (int)Percent;
        Debug.Log(breakpoint);
        text.text = "" + breakpoint;
    }
}
