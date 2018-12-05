using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//生成スクリプトUnity
public class SeiseiManager : MonoBehaviour {

	private Vector3 SeiseiPos;
	//private Vector3 pos;
	private int monsID;

	public Canvas canvas;
	int ID = 99;
	//int id = 99;

	private GameObject GoMonsterButton;
	private Vector3 seisePos;

	// Use this for initialization
	void Start () {
		ID = 99;
		//pos = tmp.transform.position;
		//座標取得、代入
		var tmp = GameObject.Find("GoMonsterButton").transform.position;
		GameObject.Find ("GoMonsterButton").transform.position = new Vector3 (tmp.x, tmp.y, tmp.z);

		GoMonsterButton = GameObject.Find ("GoMonsterButton");

		//Debug.Log ("tttt " + seisePos);


		//Debug.Log("test" + Camera.main.ScreenToWorldPoint(tmp));

		// オブジェクトの座標を取得
		SeiseiPos = Camera.main.ScreenToWorldPoint(tmp);

		//Debug.Log (tmp);
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log ("a:" + a);
		//Resources.UnloadUnusedAssets();
		//Debug.Log (id);
		Debug.Log (ID);

	}

	public void OnClick()
	{	
		Debug.Log ("ID :" + ID);
		Vector3 seisePos = Camera.main.ScreenToWorldPoint (GoMonsterButton.transform.position);
		seisePos.z = 0;

		//Debug.Log (posn);
		GameObject MonsObject = (GameObject)Resources.Load("Monst/Monster_" + ID);// +monsID);

		//GameObject cloneObject = Instantiate(MonsObject, new Vector3(SeiseiPos.x, SeiseiPos.y, 0), Quaternion.identity);
		//GameObject cloneObject = Instantiate(MonsObject, seisePos, Quaternion.identity);
		GameObject cloneObject = (GameObject)Instantiate(MonsObject);
		cloneObject.gameObject.transform.SetParent (canvas.transform, false);
		cloneObject.transform.position = seisePos;
		//cloneObject.gameObject.transform.parent = canvas.transform;
	}

	//キャラ選択
	public void Change(int num){
		//a++;
		//Debug.Log ("a " + a);
		//Debug.Log (id);
		//Debug.Log (id);
		Debug.Log (ID + ":" + num);
		ID = num;
		Debug.Log (ID + ":" + num);
	}
}