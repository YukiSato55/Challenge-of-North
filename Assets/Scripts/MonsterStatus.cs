using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStatus : MonoBehaviour {
    private int MonsID, Rank;
    public float MonsHP, MonsATK;

    [SerializeField]
    private GameObject Database;
    private GaugeValue gaugeValue;

	// Use this for initialization
	void Awake () { // AwakeじゃないとsliderのStartに反映されない
        MonsID = this.GetComponent<MonsterIDManager>().MonsterID; // ID読み取り
        if (PlayerPrefs.HasKey("MonsRank_" + MonsID) == true) // データがあれば
        {
            Rank = PlayerPrefs.GetInt("MonsRank_" + MonsID); // 読み込み
        } else
        {
            Rank = 0;                                   // 無い場合は0で始めから
            PlayerPrefs.SetInt("MonsRank_" + MonsID, Rank);
        }

        gaugeValue = this.GetComponentInChildren<GaugeValue>();
        MonsHP = Database.GetComponent<StatusDataBase>().MonsDataHP[MonsID, Rank]; // IDとRankで取得する値を決める
        MonsATK = Database.GetComponent<StatusDataBase>().MonsDataATK[MonsID, Rank];
        //Debug.Log("HP:" + MonsHP + "ATK:" + MonsATK);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MonsDamage(float ATK)
    {
        MonsHP -= 5;
        gaugeValue.GaugeDamage();
    }
}
