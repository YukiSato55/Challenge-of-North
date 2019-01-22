using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusDataBase : MonoBehaviour {
    //ステータスはHP、攻撃力の順　ID順横分け MonsID：[〇][]　強化ランク：[][〇] 速さ 成長タイプコスト
    public float[,] MonsDataHP = { 	{ 30f, 50f, 65f, 85f, 100f }, // Dragon  1.5 万能高価
                             		{ 10f, 12f, 20f, 30f, 80f }, // ワーム   2　 耐久安価
									{ 8f, 12f, 20f, 30f, 80f },//ハチ		 5	 スピード攻撃
									{ 15f, 12f, 20f, 30f, 80f },//ケルベロス 2　 攻撃
									{ 20f, 12f, 20f, 30f, 80f },//グリフォン 2.5   万能普通
									{ 30f, 12f, 20f, 30f, 80f },//エイリアン 1.5 耐久
									{ 16f, 12f, 20f, 30f, 80f },//コドラ     2   万能安価
									{ 12f, 12f, 20f, 30f, 80f },//あり       3.5 スピード耐久
									{ 15f, 12f, 20f, 30f, 80f },//デーモン   2.5 攻撃高価
									{ 23f, 12f, 20f, 30f, 80f },//巨人       1.5 耐久
									{ 12f, 12f, 20f, 30f, 80f },//スケルトン 2   攻撃
									{ 23f, 12f, 20f, 30f, 80f },//ヒドラ     1   万能
									{ 20f, 12f, 20f, 30f, 80f },//オーク     1   耐久
									{ 16f, 12f, 20f, 30f, 80f },//リザードマン2  攻撃
									{ 15f, 12f, 20f, 30f, 80f },//スネーク   3   スピード攻撃
									{ 15f, 12f, 20f, 30f, 80f },//スライム   1.5 耐久安価
									{ 12f, 12f, 20f, 30f, 80f },//トカゲ     2   万能
									{ 15f, 12f, 20f, 30f, 80f }//狼          3.5   スピード万能
                           		 };

    public float[,] MonsDataATK = { { 15f, 15f, 18f, 25f, 35f }, // Dragon
                              		{ 1f, 5f, 6f, 7f, 15f },  // ワーム
									{ 8f, 12f, 20f, 30f, 80f },//ハチ				
									{ 10f, 12f, 20f, 30f, 80f },//ケルベロス
									{ 10f, 12f, 20f, 30f, 80f },//グリフォン
									{ 6f, 12f, 20f, 30f, 80f },//エイリアン
									{ 8f, 12f, 20f, 30f, 80f },//コドラ
									{ 4f, 12f, 20f, 30f, 80f },//あり
									{ 12f, 12f, 20f, 30f, 80f },//デーモン
									{ 5f, 12f, 20f, 30f, 80f },//巨人
									{ 9f, 12f, 20f, 30f, 80f },//スケルトン
									{ 13f, 12f, 20f, 30f, 80f },//ヒドラ
									{ 7f, 12f, 20f, 30f, 80f },//オーク
									{ 10f, 12f, 20f, 30f, 80f },//リザードマン
									{ 6f, 12f, 20f, 30f, 80f },//スネーク
									{ 2f, 12f, 20f, 30f, 80f },//スライム
									{ 5f, 12f, 20f, 30f, 80f },//トカゲ
									{ 7f, 12f, 20f, 30f, 80f }//狼
							       };
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
