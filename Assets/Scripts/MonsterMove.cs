using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour {
    private int MonsID;
    private int MoveDirection = 0; // 動く方向 0：正面、1：右、2：左、3：後退
	private Animator animator;
    
    // ID順　0から17
    private float[] MonsterMoveSpeed = {0.01f, 0.015f, 0.035f,0.02f,0.02f,0.015f,0.02f,0.025f,0.025f,0.015f,0.02f,0.01f,0.01f,0.02f,0.025f,0.015f,0.02f,0.03f};   

	// Use this for initialization
	void Start () {
        MonsID = this.GetComponent<MonsterIDManager>().MonsterID;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		switch(MoveDirection)
        {

			//下方向
            case 0:
                this.gameObject.transform.Translate(0, -1 * MonsterMoveSpeed[MonsID], 0);
                break;

			//右方向
            case 1:
                this.gameObject.transform.Translate(MonsterMoveSpeed[MonsID],0 , 0);
                break;

			//左方向
            case 2:
                this.gameObject.transform.Translate(-1 * MonsterMoveSpeed[MonsID], 0, 0);
                break;

			//上方向
            case 3:
                this.gameObject.transform.Translate(0, MonsterMoveSpeed[MonsID], 0);
                break;

			//デストローイ
            case 4:
                Destroy(this.gameObject);
                break;
        }
        //Debug.Log(MoveDirection);
	}

    void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        //Debug.Log("起動"); 後で移動ブロックにタグ付けし、条件指定。
        MoveDirection = other.gameObject.GetComponent<MoveChange>().ChangeDirection;
		animator.SetInteger ("MoveChange", MoveDirection);

    }
}
