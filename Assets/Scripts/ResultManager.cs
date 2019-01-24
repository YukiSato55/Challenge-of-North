using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour {
    [SerializeField]
    private GameObject Result;
    [SerializeField]
    private ResultStar resultStar;
    [SerializeField]
    private ResultText resultText;

    int DeathCount, EnemyBreakCount, EnemyCount;
    private GameObject[] Enemy;

	// Use this for initialization
	void Awake () {
        Result.SetActive(false);
        // 保持しているモンスター数の取得
        DeathCount = 0;
        EnemyBreakCount = 0;
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
	}

    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Death()
    {
        DeathCount++;
        Debug.Log("Death" + DeathCount);


        /*if(DeathCount == 10) // 保持しているモンスター数と死んだモンスター数が一致した場合
        {
            Result.SetActive(true);
        }*/
    }

    public void MainBreak()
    {
        Result.SetActive(true);
        resultText.Clear();
        resultStar.CheckStar(EnemyBreakCount);
    }
}
