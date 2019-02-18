using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//画面遷移スクリプト
public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start() {
		
	}

	// Update is called once per frame
	void Update() {
			
		}

	public void GoHome(){
		if (SceneManager.GetActiveScene ().name != "home") {
			SceneManager.LoadScene ("home");
			Debug.Log ("ホームに移動します");
		}
	}
	public void GOMenu(){
		if (SceneManager.GetActiveScene ().name != "Menu") {
			SceneManager.LoadScene ("Menu");
			Debug.Log ("メニュー画面に移動します");
		}
	}
	public void Stageselect(){
		if (SceneManager.GetActiveScene ().name != "Stageselect") {
			SceneManager.LoadScene ("Stageselect");
			Debug.Log ("ステージ選択画面移動します");
		}
	}
	public void Upgrade(){
		if (SceneManager.GetActiveScene ().name != "Upgrade") {
			SceneManager.LoadScene ("Upgrade");
			Debug.Log ("強化画面に移動します");
		}
	}
	public void Battle1(){
		if (SceneManager.GetActiveScene ().name != "Battle1-1") {
			SceneManager.LoadScene ("Battle1-1");
			Debug.Log ("ステージ1-1に移動します");
		}
	}
	public void GoTitle(){
		SceneManager.LoadScene ("Title");
	}

    public void GiveGoScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}