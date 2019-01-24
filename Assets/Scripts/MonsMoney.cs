using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsMoney : MonoBehaviour {

    [SerializeField]
    private MonsterIDManager iDManager;
    private int ID, Rank;
    private float cost;
    private StatusDataBase monsterStatus;
    private Text text;

	// Use this for initialization
	void Start () {
        monsterStatus = GameObject.Find("MonsStatusDatabase").GetComponent<StatusDataBase>();
        text = GetComponent<Text>();
        ID = iDManager.MonsterID;
        Rank = iDManager.MonsterRank;
        cost = monsterStatus.MonsDataMani[ID, Rank];
        text.text = "" + cost;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
