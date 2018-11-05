using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    private float chargeTime = 0;
    private Vector3 pos;
    private GameObject weapon;

    // Use this for initialization
    void Start()
    {
        pos = this.transform.position;
        weapon = (GameObject)Resources.Load("Weapon/koji1_8");
        Debug.Log(weapon);
    }
	
	// Update is called once per frame
	void Update () {
        chargeTime += Time.deltaTime;

        if (chargeTime >= 1.0f)
        {
            GameObject cloneobj = Instantiate(weapon, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            chargeTime = 0;
        }
    }
}
