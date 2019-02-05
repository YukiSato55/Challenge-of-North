using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JihankiTouch : MonoBehaviour {
    [SerializeField]
    private GameObject Textobj;
    private GameObject gameObject;
    private Vector3 pos;
    [SerializeField]
    private Transform Parent;

	// Use this for initialization
	void Start () {
        pos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Form()
    {
        gameObject = (GameObject)Instantiate(Textobj, new Vector3(pos.x, pos.y + 30.0f, pos.z), Quaternion.identity, Parent);
    }
}
