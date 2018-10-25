using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start() {
		
	}

	// Update is called once per frame
	void Update() {
			
		}

	public void GoHome(){
		SceneManager.LoadScene("home");
		Debug.Log ("ホームに移動します");
	}
	public void GOMenu(){
		SceneManager.LoadScene ("Menu");
		Debug.Log ("メニュー画面に移動します");
	}
	public void Stageselect(){
		SceneManager.LoadScene ("Stageselect");
		Debug.Log ("ステージ選択画面移動します");
	}
	public void Upgrade(){
		SceneManager.LoadScene ("Upgrade");
		Debug.Log ("強化画面に移動します");
	}
	public void Battle1(){
		SceneManager.LoadScene ("Battle1-1");
		Debug.Log ("ステージ1-1に移動します");
	}
}