using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStatus : MonoBehaviour {
	private Renderer renderer;
    private int MonsID, Rank;

    //旧式:GaugeValue
    //最新:Gauge2Value

    public float MonsHP, MonsATK;

    [SerializeField]
    private GameObject Database;
    private StatusDataBase Data;
    private Gauge2Value gaugeValue;
    private ResultManager resultManager;

    private SEManager se;
    private BattleSEDate SEDate;
    private AudioClip SEclip;

    // Use this for initialization
    void Start () {
		renderer = GetComponent<Renderer>();
        se = GameObject.Find("SEManager").GetComponent<SEManager>();
        SEDate = GameObject.Find("SEManager").GetComponent<BattleSEDate>();
        //GameClearText.SetActive(false);
    }

	// Use this for initialization
	void Awake () { // AwakeじゃないとsliderのStartに反映されない
        Data = GameObject.Find("MonsStatusDatabase").GetComponent<StatusDataBase>();
        MonsID = GetComponent<MonsterIDManager>().MonsterID; // ID読み取り
        if (PlayerPrefs.HasKey("MonsRank_" + MonsID))
        {
            Rank = PlayerPrefs.GetInt("MonsRank_" + MonsID);
        } else
        {
            Rank = 0;
            PlayerPrefs.SetInt("MonsRank_" + MonsID, Rank);
        }
        MonsHP = Data.MonsDataHP[MonsID, Rank];
        MonsATK = Data.MonsDataATK[MonsID, Rank];
    }
	
	// Update is called once per frame
	void Update () {
		if(MonsHP <= 0)
        {
            resultManager.Death();
            //TakeSEはこっちから送る文字で返すやつを決める
            SEclip = SEDate.TakeSE("Death");
            se.GiveOnClick(SEclip);
            Destroy(this.gameObject);
        }
	}

    public void MonsDamage(float ATK)
    {
        MonsHP -= ATK;
		//ダメージを受けたら点滅
		StartCoroutine ("Damage");
        gaugeValue.GaugeDamage();
        if(MonsHP > 0)
        {
            //TakeSEはこっちから送る文字で返すやつを決める
            SEclip = SEDate.TakeSE("Damage");
            se.GiveOnClick(SEclip);
        } 
    }

    public void DecisionStatus()
    {
        Rank = GetComponent<MonsterIDManager>().MonsterRank; // Rank読み取り
        gaugeValue = this.GetComponentInChildren<Gauge2Value>();
        MonsHP = Database.GetComponent<StatusDataBase>().MonsDataHP[MonsID, Rank]; // IDとRankで取得する値を決める
        MonsATK = Database.GetComponent<StatusDataBase>().MonsDataATK[MonsID, Rank];
        resultManager = GameObject.Find("ResultManager").GetComponent<ResultManager>();
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
