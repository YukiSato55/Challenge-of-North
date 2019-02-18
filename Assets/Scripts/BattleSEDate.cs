using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSEDate : MonoBehaviour {
    [SerializeField]
    private AudioClip Damage, Death;
    //増え次第、随時追加、一括管理

    private AudioClip SE;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public AudioClip TakeSE(string Request)
    {
        switch(Request)
        {
            case "Damage":
                return Damage;
                break;

            case "Death":
                return Death;
                break;

        }
        //Debug.Log(SE);
        if (SE = null) Debug.Log("Error!!: SE is null(多分”変数:Request”が仕様と違うてますよ!)");
        return SE;
    }
}
