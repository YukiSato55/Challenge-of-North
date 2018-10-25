using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeiseiManager : MonoBehaviour {
    private Vector3 SeiseiPos;
    private Vector3 pos;
    private int monsID;

	// Use this for initialization
	void Start () {
        pos = this.transform.position;
        //Debug.Log("test" + Camera.main.ScreenToWorldPoint(pos));

        // オブジェクトの座標を取得
        SeiseiPos = Camera.main.ScreenToWorldPoint(pos);
    }
	
	// Update is called once per frame
	void Update () {
        Resources.UnloadUnusedAssets();
    }

    public void OnClick()
    {
        GameObject MonsObject = (GameObject)Resources.Load("Monster_0");// +monsID);
        GameObject cloneObject = Instantiate(MonsObject, SeiseiPos, Quaternion.identity);
    }
}
