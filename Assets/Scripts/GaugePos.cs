using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugePos : MonoBehaviour {
    [SerializeField]
    private Transform MonsTrans;

    private RectTransform MyTrans;
    private Vector3 offset = new Vector3(0, 0.5f, 0);


	// Use this for initialization
	void Start () {
        MyTrans = GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        MyTrans.position
            = RectTransformUtility.WorldToScreenPoint(Camera.main, MonsTrans.position + offset);
    }

    public void Damege(float Damege)
    {

    }
}
