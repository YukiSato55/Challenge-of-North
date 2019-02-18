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
        //ctor3 pos = this.gameObject.transform.position;
        RectTransform rect = GetComponent<RectTransform>();
        //Debug.Break();
        
		if (rect.anchoredPosition.y < -100 && F == true) {

            rect.anchoredPosition = new Vector2 (rect.anchoredPosition.x, rect.anchoredPosition.y + 16);
			//Debug.Log ("a" + rect.anchoredPosition.y);
		} else if (rect.anchoredPosition.y > -540 && F == false) {

            rect.anchoredPosition = new Vector2 (rect.anchoredPosition.x, rect.anchoredPosition.y - 16);
			//Debug.Log ("b" + rect.anchoredPosition.y);
		}
        //Debug.Log(rect.anchoredPosition.y);
        
        //pos = new Vector3(pos.x, rect.anchoredPosition.y + 8.0f, pos.z);
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