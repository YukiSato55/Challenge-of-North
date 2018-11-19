using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponATK : MonoBehaviour {
    MonsterStatus monsterStatus;
    [SerializeField]
    private float ATK;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
    {
		Debug.Log ("aaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        switch(other.tag)
        {
		case "Monster":
			monsterStatus = other.GetComponent<MonsterStatus> ();
			monsterStatus.MonsDamage (ATK);

                Destroy(this.gameObject);
                break;
        }
    }
}
