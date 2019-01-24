using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SUMBuyMoney : MonoBehaviour {
    private float SUM;

	// Use this for initialization
	void Start () {
        SUM = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SUMMoney(float cost)
    {
        SUM += cost;
    }

    public float Return()
    {
        Debug.Log("kidou");
        return SUM;
    }
}
