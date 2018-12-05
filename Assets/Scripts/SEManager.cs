using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour {
    private AudioSource GetSE;

	// Use this for initialization
	void Start () {
        GetSE = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        GetSE.PlayOneShot(GetSE.clip);
    }
}
