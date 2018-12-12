using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WeaponSeisei : MonoBehaviour {
    private float chargeTime = 2f;
    private float time = 0;

    [SerializeField]
    [Header("親obj敵キャラ")]
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
            transform.position = Vector3.MoveTowards(transform.position, EnemyPos, speed);
            Debug.Log(basePos + "突撃" + EnemyPos);
            if (transform.position == EnemyPos)
            {
                Destroy(this.gameObject);
            }
        }
    }
    
    /// <summary>
    /// 防衛設備から武器を出す処理
    /// </summary>
    /// <param name="Pos">モンスターの現在地</param>
    public void Shot(GameObject MonsPos)
    {
        if(!this.name.Contains("(Clone)"))
        {
            Vector3 diff = (MonsPos.gameObject.transform.position - this.transform.position);
            this.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);
            Instantiate(this, new Vector3(basePos.x, basePos.y, basePos.z), transform.rotation);

        }
    }
}
