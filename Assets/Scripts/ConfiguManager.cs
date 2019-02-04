using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConfiguManager : MonoBehaviour {

	[SerializeField]
	private GameObject Pane;
	[SerializeField]
	private GameObject Pane2;
	[SerializeField]
	private Text targetText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Select(int Pnum){
		//Debug.Log (Pnum + "を取得。");
		Pane.SetActive (true);
		switch (Pnum) {
		case 0:
			targetText.text = "金ちゃんと一緒に\n侵略しよう！！";
			break;
		case 1:
			Pane2.SetActive (true);
			break;
		case 2:
			targetText.text = "クレジット";
			break;
		}
	}

	public void SeleBack(int Bnum){
		switch (Bnum) {
		case 0:
			Pane.SetActive (false);
			break;
		case 1:
			Pane2.SetActive (false);
			break;
		}
	}
}