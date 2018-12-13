using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour {
    GameObject Result;
    int DeathCount;

	// Use this for initialization
	void Awake () {
        Result = GameObject.Find("Result");
        Result.SetActive(false);
        // 保持しているモンスター数の取得
        DeathCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Death()
    {
        DeathCount++;
        Debug.Log("Death" + DeathCount);
        if(DeathCount == 10) // 保持しているモンスター数と死んだモンスター数が一致した場合
        {
            Result.SetActive(true);
        }
    }

    public void MainBreak()
    {
        Result.SetActive(true);
    }
}
