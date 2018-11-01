using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour {
    private int MonsID;
    private int MoveDirection = 0; // 動く方向 0：正面、1：右、2：左、3：後退
    
    // ID順　0から
    private float[] MonsterMoveSpeed = {0.01f, 0.02f, 0.03f};   

	// Use this for initialization
	void Start () {
        MonsID = this.GetComponent<MonsterIDManager>().MonsterID;
	}
	
	// Update is called once per frame
	void Update () {
		switch(MoveDirection)
        {
            case 0:
                this.gameObject.transform.Translate(0, -1 * MonsterMoveSpeed[MonsID], 0);
                break;

            case 1:
                this.gameObject.transform.Translate(MonsterMoveSpeed[MonsID],0 , 0);
                break;

            case 2:
                this.gameObject.transform.Translate(-1 * MonsterMoveSpeed[MonsID], 0, 0);
                break;

            case 3:
                this.gameObject.transform.Translate(0, MonsterMoveSpeed[MonsID], 0);
                break;

            case 4:
                Destroy(this.gameObject);
                break;
        }
        //Debug.Log(MoveDirection);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("起動"); 後で移動ブロックにタグ付けし、条件指定。
        MoveDirection = other.gameObject.GetComponent<MoveChange>().ChangeDirection;
    }
}
