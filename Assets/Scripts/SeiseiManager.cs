using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//生成スクリプトUnity
public class SeiseiManager : MonoBehaviour {
    private Vector3 SeiseiPos;
    private Vector3 pos;
    private int monsID;

	public Canvas canvas;
	//public int ID = 99;
	int id = 99;
	int a = 0;
	private int ID
	{
		set {
			Debug.Log (value + " set");
			this.id = value; }
		get {
			Debug.Log (this.id + " get");
			return this.id; }
	}

	//public int id;

	// Use this for initialization
	void Start () {
		ID = id;
        pos = this.transform.position;
        //Debug.Log("test" + Camera.main.ScreenToWorldPoint(pos));

        // オブジェクトの座標を取得
        SeiseiPos = Camera.main.ScreenToWorldPoint(pos);
    }
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("a:" + a);
       // Resources.UnloadUnusedAssets();

    }

    public void OnClick()
    {
       // GameObject MonsObject = (GameObject)Resources.Load("Monst/Monster_" + ID);// +monsID);
       // GameObject cloneObject = Instantiate(MonsObject, new Vector3(SeiseiPos.x, SeiseiPos.y, 0), Quaternion.identity);
		//cloneObject.gameObject.transform.parent = canvas.transform;
    }

	//キャラ選択
	public void Change(int num){
		a++;
		Debug.Log ("a " + a);
		Debug.Log (id);
		ID = num;
		Debug.Log (id);
		//Debug.Log (ID + ":" + num);
		//ID = num;
		//Debug.Log (ID + ":" + num);
	}

}