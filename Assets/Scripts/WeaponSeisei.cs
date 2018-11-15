using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WeaponSeisei : MonoBehaviour {
    private float chargeTime = 2f;
    private float time = 0;

    [SerializeField]
    private GameObject thisobj;
    [SerializeField]
    private float speed;
    private Vector3 basePos, EnemyPos;
    private EnemyAttackRange EAR;
    DateTime eee;

	// Use this for initialization
	void Start () {
        
        basePos = this.transform.position;
        if (this.name.Contains("(Clone)"))
        {
            EAR = thisobj.GetComponent<EnemyAttackRange>();
            Debug.Log(EAR);
            EnemyPos = EAR.getTargetObj().transform.position;
            
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (this.name.Contains("(Clone)"))
        {
            Debug.Log(basePos + "突撃" + EnemyPos);
            transform.position = Vector3.MoveTowards(transform.position, EnemyPos, speed);
            Debug.Log(this.transform.position);
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
            Instantiate(this, new Vector3(basePos.x, basePos.y, basePos.z), Quaternion.identity);
            Vector3 diff = (Pos.gameObject.transform.position - this.transform.position);
            this.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);
            Debug.Log(eee + " " + EnemyPos);

        }
    }
}
