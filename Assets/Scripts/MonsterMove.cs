using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour {
    private int MonsID;
    private int MoveDirection = 0; // 動く方向 0：正面、1：右、2：左、3：後退
    private float[] MonsterMoveSpeed = {0.01f, 0.02f, 0.03f};   

	// Use this for initialization
	void Start () {
        MonsID = this.GetComponent<MonsterIDManager>().MonsterID;
	}
	
	// Update is called once per frame
	void Update () {
        //if()
		switch(MoveDirection)
        {
            case 0:
                this.gameObject.transform.Translate(0, MonsterMoveSpeed[MonsID], 0);
                break;
        }
	}

    void Move()
    {

    }
}
