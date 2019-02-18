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
	[SerializeField]
	private Text tagetText;
	[SerializeField]
	private GameObject Kim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Select(int Pnum){
		//Debug.Log (Pnum + "を取得。");
		switch (Pnum) {
		case 0:
			Pane.SetActive (true);
			Kim.SetActive (true);
			targetText.text = "僕と一緒に\n侵略しよう！！";
			tagetText.text = "ぶっ潰して\nやろうか！！";
			//Kim.sprite = "kin4";
			break;
		case 1:
			Pane2.SetActive (true);
			tagetText.text = "音量を\n変えられるよ♥";
			break;
		case 2:
			Pane.SetActive (true);
			targetText.text = "クレジット";
			tagetText.text = "クレジット\nだよ";
			break;
		}
	}

	public void SeleBack(int Bnum){
		switch (Bnum) {
		case 0:
			Pane.SetActive (false);
			Kim.SetActive (false);
			tagetText.text = "何でも聞いてよ！";
			break;
		case 1:
			Pane2.SetActive (false);
			tagetText.text = "何でも\n聞いてよ！";
			break;
		}
	}
}