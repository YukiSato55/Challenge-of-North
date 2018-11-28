using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//生成スクリプトUnity
public class SeiseiManager : MonoBehaviour {
	
    private Vector3 SeiseiPos;
    private Vector3 Gotra;
    private int monsID;

	public Canvas canvas;
	int ID = 99;
	int id = 99;

	// Use this for initialization
	void Start () {
		ID = 99;
		//pos = posn.transform.position;
		var Gotra = GameObject.Find("GoMonsterButton").transform;
		Debug.Log("test" + Camera.main.ScreenToWorldPoint(Gotra));

		// オブジェクトの座標を取得
		SeiseiPos = Camera.main.ScreenToWorldPoint(Gotra);

		Debug.Log (Gotra);
    }
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("a:" + a);
       	Resources.UnloadUnusedAssets();
		Debug.Log (id);
		Debug.Log (ID);

    }

    public void OnClick()
    {
		//Debug.Log (posn);

        GameObject MonsObject = (GameObject)Resources.Load("Monst/Monster_" + ID);// +monsID);
        GameObject cloneObject = Instantiate(MonsObject, new Vector3(SeiseiPos.x, SeiseiPos.y, 0), Quaternion.identity);
		cloneObject.gameObject.transform.parent = canvas.transform;
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