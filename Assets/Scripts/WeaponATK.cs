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
    void OnCollisionEnter2D(Collider2D other)
    {
        switch(other.tag)
        {
            case "Monster":
                monsterStatus = other.GetComponent<MonsterStatus>();
                monsterStatus.MonsDamage(ATK);
                Destroy(this.gameObject);
                break;
        }
    }
}
