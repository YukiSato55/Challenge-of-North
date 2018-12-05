using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMove : MonoBehaviour {

	bool F = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//タブの出し入れ
		Vector3 pos = this.gameObject.transform.position;
		//Debug.Log (pos.y);
		if (pos.y < 100 && F == true) {
			this.gameObject.transform.position = new Vector3 (pos.x, pos.y + 8.0f, pos.z);
			Debug.Log ("aaaaaaaaaaaaaaaaaaaaaaaaa");
		} else if (pos.y > -100 && F == false) {
			this.gameObject.transform.position = new Vector3 (pos.x, pos.y - 8.0f, pos.z);
			Debug.Log ("bbbbbbbbbbbbbbbbbbbbbbbbb");
		}
	}

	//タブの関連
	public void Tupon(){
		if (F != true) {
			F = true;
			Debug.Log ("trueが入った");
		}else if(F == true){
			F = false;
			Debug.Log ("falseが入った");
		}
	}
}