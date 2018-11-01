using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusDataBase : MonoBehaviour {
    //ステータスはHP、攻撃力の順　ID順横分け MonsID：[〇][]　強化ランク：[][〇]
    public float[,] MonsDataHP = { { 40f, 50f, 65f, 85f, 100f }, // Dragon
                             { 10f, 12f, 20f, 30f, 80f }  // ワーム
                            };

    public float[,] MonsDataATK = { { 10f, 15f, 18f, 25f, 35f }, // Dragon
                              { 3f, 5f, 6f, 7f, 15f }  // ワーム
                             };
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
