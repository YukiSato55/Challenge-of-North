using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpGradePanel : MonoBehaviour {
    //private GameObject FormPosObj;
    private Vector3 FormPos;

	// Use this for initialization
	void Start () {
        FormPos = GameObject.Find("FormPos").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick(int ID)
    {

    }
}
