using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JihankiTouch : MonoBehaviour {
    [SerializeField]
    private GameObject gameObject;
    private Vector3 pos;
    private 

	// Use this for initialization
	void Start () {
        pos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Form()
    {
        //Instantiate(gameObject, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity, );
    }
}
