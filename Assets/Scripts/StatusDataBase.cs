using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusDataBase : MonoBehaviour {
    //ステータスはHP、攻撃力の順　ID順横分け MonsID：[〇][]　強化ランク：[][〇]
    public float[,] MonsDataHP = { 	{ 40f, 50f, 65f, 85f, 100f }, // Dragon
                             		{ 10f, 12f, 20f, 30f, 80f }, // ワーム
									{ 10f, 12f, 20f, 30f, 80f },//ハチ				
									{ 10f, 12f, 20f, 30f, 80f },//ケルベロス
									{ 10f, 12f, 20f, 30f, 80f },//グリフォン
									{ 10f, 12f, 20f, 30f, 80f },//エイリアン
									{ 10f, 12f, 20f, 30f, 80f },//コドラ
									{ 10f, 12f, 20f, 30f, 80f },//あり
									{ 10f, 12f, 20f, 30f, 80f },//デーモン
									{ 10f, 12f, 20f, 30f, 80f },//巨人
									{ 10f, 12f, 20f, 30f, 80f },//スケルトン
									{ 10f, 12f, 20f, 30f, 80f },//ヒドラ
									{ 10f, 12f, 20f, 30f, 80f },//オーク
									{ 10f, 12f, 20f, 30f, 80f },//リザードマン
									{ 10f, 12f, 20f, 30f, 80f },//スネーク
									{ 10f, 12f, 20f, 30f, 80f },//スライム
									{ 10f, 12f, 20f, 30f, 80f },//トカゲ
									{ 10f, 12f, 20f, 30f, 80f }//狼
                           		 };

    public float[,] MonsDataATK = { { 10f, 15f, 18f, 25f, 35f }, // Dragon
                              		{ 3f, 5f, 6f, 7f, 15f },  // ワーム
									{ 10f, 12f, 20f, 30f, 80f },//ハチ				
									{ 10f, 12f, 20f, 30f, 80f },//ケルベロス
									{ 10f, 12f, 20f, 30f, 80f },//グリフォン
									{ 10f, 12f, 20f, 30f, 80f },//エイリアン
									{ 10f, 12f, 20f, 30f, 80f },//コドラ
									{ 10f, 12f, 20f, 30f, 80f },//あり
									{ 10f, 12f, 20f, 30f, 80f },//デーモン
									{ 10f, 12f, 20f, 30f, 80f },//巨人
									{ 10f, 12f, 20f, 30f, 80f },//スケルトン
									{ 10f, 12f, 20f, 30f, 80f },//ヒドラ
									{ 10f, 12f, 20f, 30f, 80f },//オーク
									{ 10f, 12f, 20f, 30f, 80f },//リザードマン
									{ 10f, 12f, 20f, 30f, 80f },//スネーク
									{ 10f, 12f, 20f, 30f, 80f },//スライム
									{ 10f, 12f, 20f, 30f, 80f },//トカゲ
									{ 10f, 12f, 20f, 30f, 80f }//狼
							       };
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
