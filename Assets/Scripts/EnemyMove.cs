using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    [SerializeField]
    private int MoveDirection = 0; // 動く方向 0：正面、1：右、2：左、3：後退、４：停止
    [SerializeField]
    private float MoveSpeed;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (MoveDirection)
        {

            //下方向
            case 0:
                this.gameObject.transform.Translate(0, -1 * MoveSpeed, 0);
                break;

            //右方向
            case 1:
                this.gameObject.transform.Translate(MoveSpeed, 0, 0);
                break;

            //左方向
            case 2:
                this.gameObject.transform.Translate(-1 * MoveSpeed, 0, 0);
                break;

            //上方向
            case 3:
                this.gameObject.transform.Translate(0, MoveSpeed, 0);
                break;

            case 4:
                this.gameObject.transform.Translate(0, 0, 0);
                break;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        //Debug.Log("起動"); 後で移動ブロックにタグ付けし、条件指定。
        switch (other.tag)
        {
            case "Move":
                MoveDirection = other.gameObject.GetComponent<MoveChange>().ChangeDirection;
                break;

        }
    }
}
