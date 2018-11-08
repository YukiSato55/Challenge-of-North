using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSeisei : MonoBehaviour {
    private string ThisObjName;
    private float chargeTime = 2f;
    private float time = 0;
    private Vector3 basePos, targetPos;
    private float targetAngle, dAngle;
    GameObject thisobj, targetobj;


	// Use this for initialization
	void Start () {
        basePos = this.GetComponent<Vector3>();
	}
	
	// Update is called once per frame
	void Update () {
        if (ThisObjName.Contains("(Clone)"))
        {

   
        }
    }

    public void AngleSeisei(GameObject obj)
    {
        targetPos = obj.transform.position;
    }
}
