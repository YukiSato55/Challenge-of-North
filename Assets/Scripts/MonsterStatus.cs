using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStatus : MonoBehaviour {
	private Renderer renderer;
    private int MonsID, Rank;

    public float MonsHP, MonsATK;

    [SerializeField]
    private GameObject Database;
    private GaugeValue gaugeValue;
    private ResultManager resultManager;

    // Use this for initialization
    void Start () {
		renderer = GetComponent<Renderer>();
		//GameClearText.SetActive(false);
	}

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
        resultManager = GameObject.Find("ResultManager").GetComponent<ResultManager>();
        Debug.Log("syutoku:" + resultManager);
    }
	
	// Update is called once per frame
	void Update () {
		if(MonsHP <= 0)
        {
            resultManager.Death();
            Destroy(this.gameObject);
        }
	}

    public void MonsDamage(float ATK)
    {
        MonsHP -= ATK;
		//ダメージを受けたら点滅
		StartCoroutine ("Damage");
        gaugeValue.GaugeDamage();
    }

	//点滅の処理
	IEnumerator Damage (){

		int count = 10;
		while (count > 0) {
			//透明にする
			renderer.material.color = new Color (1, 1, 1, 0);
			//0.06秒待つ
			yield return new WaitForSeconds(0.06f);
			//元に戻す
			renderer.material.color = new Color(1,1,1,1);
			//0.06秒待つ
			yield return new WaitForSeconds(0.06f);
			count--;
		}
	}
}
