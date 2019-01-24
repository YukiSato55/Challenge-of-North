using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfiguManager : MonoBehaviour {

	[SerializeField]
	private GameObject Pane;
	[SerializeField]
	private Text targetText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Select(int Pnum){
		Debug.Log (Pnum + "を取得。");
		Pane.SetActive (true);
		switch (Pnum) {
		case 0:
			targetText.text = "金ちゃんと一緒に\n侵略しよう！！";
			break;
		case 1:
			targetText.text = "コンフィグ";
			break;
		case 2:
			targetText.text = "その他";
			break;
		case 3:
			targetText.text = "クレジット";
			break;
		}
	}

	public void SeleBack(){
		Pane.SetActive (false);
	}
}