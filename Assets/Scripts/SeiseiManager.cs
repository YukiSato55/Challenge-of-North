using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//生成スクリプトUnity
public class SeiseiManager : MonoBehaviour {
    private Vector3 SeiseiPos;
    private Vector3 pos;
    private int monsID;

	public Canvas canvas;

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
        GameObject MonsObject = (GameObject)Resources.Load("Monst/Monster_14");// +monsID);
        GameObject cloneObject = Instantiate(MonsObject, new Vector3(SeiseiPos.x, SeiseiPos.y, 0), Quaternion.identity);
		cloneObject.gameObject.transform.parent = canvas.transform;
    }
}