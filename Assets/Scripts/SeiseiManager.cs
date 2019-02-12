using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//生成スクリプトUnity
public class SeiseiManager : MonoBehaviour {

	private Vector3 SeiseiPos;
	//private Vector3 pos;
	private int monsID;
    private MonsterMove monsterMove;
    [SerializeField]
    private int SendDirection;


	public Canvas canvas;
	int ID = 99;

	private GameObject GoMonsterButton;
	private Vector3 seisePos;

    [SerializeField]
    private BattleMoney battleMoney;

    // Use this for initialization
    void Start () {
		ID = 99;
        //pos = tmp.transform.position;
        //座標取得、代入
        var tmp = GameObject.Find("GoMonsterButton").transform.position;
		GameObject.Find ("GoMonsterButton").transform.position = new Vector3 (tmp.x, tmp.y, tmp.z);

		GoMonsterButton = GameObject.Find ("GoMonsterButton");

		// オブジェクトの座標を取得
		SeiseiPos = Camera.main.ScreenToWorldPoint(tmp);

	}

	// Update is called once per frame
	void Update () {
		//Debug.Log ("a:" + a);
		//Resources.UnloadUnusedAssets();
		//Debug.Log (id);

	}

	public void OnClick()
	{

        RectTransform seiseiPos = GameObject.Find("GoMonsterButton").GetComponent<RectTransform>();
        //Debug.Log(seiseiPos);
        
        if (ID != 99)
        {
            bool SeiseiF = false;
            SeiseiF = battleMoney.BuyMons(ID, SeiseiF);
            if (SeiseiF)
            {


                Vector3 seisePos = GetWorldPositionFromRectPosition(seiseiPos);
                Debug.Log(seisePos);
                GameObject MonsObject = (GameObject)Resources.Load("Monst/Monster_" + ID);// +monsID);
                GameObject cloneObject = (GameObject)Instantiate(MonsObject, seisePos, Quaternion.identity);
                cloneObject.GetComponent<MonsterMove>().StartMove(SendDirection);
            }
        }
        
        /*
        Vector3 seisePos = Camera.main.ScreenToWorldPoint (GoMonsterButton.transform.position);
        seisePos.z = 0;
            if (ID != 99) {
            //Debug.Log (posn);
            bool SeiseiF = false;
            SeiseiF = battleMoney.BuyMons(ID, SeiseiF);
            if (SeiseiF)
            {
                GameObject MonsObject = (GameObject)Resources.Load("Monst/Monster_" + ID);// +monsID);
                GameObject cloneObject = (GameObject)Instantiate(MonsObject);
                cloneObject.gameObject.transform.SetParent(canvas.transform, false);
                cloneObject.transform.position = seisePos;
                //cloneObject.gameObject.transform.parent = canvas.transform;
            }
        }
        */
            
    }

	//キャラ選択
	public void Change(int num){
		ID = num;
		//Debug.Log (ID + ":" + num);
	}


    private Vector3 GetWorldPositionFromRectPosition(RectTransform rect)
    {
        //UI座標からスクリーン座標に変換
        Vector2 screenPos = RectTransformUtility.WorldToScreenPoint(canvas.worldCamera, rect.position);

        //ワールド座標
        Vector3 result = Vector3.zero;

        //スクリーン座標→ワールド座標に変換
        RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, screenPos, canvas.worldCamera, out result);

        return result;
    }
}