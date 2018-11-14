using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackRange : MonoBehaviour
{
    private GameObject nearObj;//最も近いオブジェクト

    [SerializeField]
    private float range, ATKTime; // 攻撃範囲
    private float searchTime = 0;    //経過時間
    private float radian, degree; // ラジアン、角度
    float tmpDis = 0;           //距離用一時変数
    float nearDis = 0;          //最も近いオブジェクトの距離
    private Vector3 basePos, targetPos, kyori;
    private float targetAngle, dAngle;
    WeaponSeisei weaponSeisei;
    private GameObject targetObj = null;

    // Use this for initialization
    void Start()
    {
        weaponSeisei = this.GetComponentInChildren<WeaponSeisei>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //経過時間を取得
        searchTime += Time.deltaTime;
        ATKTime -= Time.deltaTime;

        if (searchTime >= 0.5f)
        {
            // Debug.Log("動いとる");

            
            if (!targetObj)
            {
                //最も近かったオブジェクトを取得
                nearObj = serchTag(gameObject, "Monster");
                AngleSeisei(nearObj);
            } else
            {
                // 射程範囲外
                nearDis = Vector3.Distance(targetObj.transform.position, gameObject.transform.position);
                if (nearDis >= range)
                {
                    targetObj = null;
                }
            }

            //経過時間を初期化
            searchTime = 0;
        }

        if(ATKTime <= 0 && targetObj)
        {
            weaponSeisei.Shot(targetObj);
        }

        //対象の位置の方向を向く
        //transform.LookAt(nearObj.transform);

    }

    //指定されたタグの中で最も近いものを取得
    GameObject serchTag(GameObject nowObj, string tagName)
    {
        tmpDis = 0;           //距離用一時変数
        nearDis = 0;          //最も近いオブジェクトの距離
        //string nearObjName = "";    //オブジェクト名称
        targetObj = null; //オブジェクト

        //タグ指定されたオブジェクトを配列で取得する
        foreach (GameObject obs in GameObject.FindGameObjectsWithTag(tagName))
        {
            //自身と取得したオブジェクトの距離を取得
            tmpDis = Vector3.Distance(obs.transform.position, nowObj.transform.position);
            Debug.Log(tmpDis + "  " + range);

            //オブジェクトの距離が近いか、距離0であればオブジェクト名を取得
            if (nearDis == 0 || nearDis > tmpDis && tmpDis <= range)
            {
                Debug.Log("入っとる");
                //一時変数に距離を格納
                nearDis = tmpDis;

                //nearObjName = obs.name;
                targetObj = obs;
            }

        }
        //最も近かったオブジェクトを返す
        //return GameObject.Find(nearObjName);
        //Debug.Log(targetObj.transform.position);
        return targetObj;
    }


    public void AngleSeisei(GameObject obj)
    {
        targetPos = obj.transform.position;
        //Debug.Log(targetPos + "  " + basePos);
        kyori = targetPos - basePos;

        // ラジアン
        radian = Mathf.Atan2(kyori.y, kyori.x);

        // 角度
        degree = radian * Mathf.Rad2Deg;

        //Debug.Log("角度" + degree);
    }

}
