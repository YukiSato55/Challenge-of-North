using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSeisei : MonoBehaviour {
    private float chargeTime = 2f;
    private float time = 0;

    GameObject thisobj, targetobj;
    private Vector3 basePos, EnemyPos;

	// Use this for initialization
	void Start () {
        basePos = this.transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        time += Time.deltaTime;
        if (this.name.Contains("(Clone)"))
        {
            Vector3.MoveTowards(basePos, EnemyPos, 0.4f);
            if(basePos == EnemyPos)
            {
                Destroy(this.gameObject);
            }
        }
    }
    

    public void Shot(GameObject Pos)
    {
        if(!this.name.Contains("(Clone)"))
        {
            Instantiate(this, new Vector3(), Quaternion.identity);
            transform.LookAt(Pos.transform);
            EnemyPos = Pos.transform.position;

        }
    }
}
