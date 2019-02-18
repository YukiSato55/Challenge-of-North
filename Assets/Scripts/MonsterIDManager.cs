using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterIDManager : MonoBehaviour {
    public int MonsterID;
    public int MonsterRank;
    private MonsterStatus monsterStatus;

    //モンスターID一覧
    /*
    0: 	ドラゴン
    1: 	ワーム
	2: 	ハチ				
	3: 	ケルベロス
	4:	グリフォン
	5:	エイリアン
	6:	コドラ
	7:	あり
	8:	デーモン
	9:	巨人
	10:	スケルトン
	11:	ヒドラ
	12:	オーク
	13:	リザードマン
	14:	スネーク
	15:	スライム
	16:	トカゲ
	17:	狼
    */ 

	// Use this for initialization
	void Awake () {
        monsterStatus = GetComponent<MonsterStatus>();
        if (PlayerPrefs.HasKey("MonsRank_" + MonsterID) == true) // データがあれば
        {
            MonsterRank = PlayerPrefs.GetInt("MonsRank_" + MonsterID); // 読み込み
        }
        else
        {
            MonsterRank = 0;                                   // 無い場合は0で始めから
            PlayerPrefs.SetInt("MonsRank_" + MonsterID, MonsterRank);
        }
        monsterStatus.DecisionStatus();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
