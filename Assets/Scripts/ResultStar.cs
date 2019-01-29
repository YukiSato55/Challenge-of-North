using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultStar : MonoBehaviour {
    [SerializeField]
    private Sprite falseStar, trueStar;
    private Image main, sub100, subCost;

	// Use this for initialization
	void Start () {
        main = GameObject.Find("MainStar").GetComponent<Image>();
        sub100 = GameObject.Find("SubStar100%").GetComponent<Image>();
        subCost = GameObject.Find("SubStarCost").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckStar(int EnemyBreakCount, float NorumaCost)
    {
        main.sprite = trueStar;
        //if(人の破壊率　>= 100) {}
        sub100.sprite = trueStar;
        if(NorumaCost >= GameObject.Find("SUMBuyMoney").GetComponent<SUMBuyMoney>().SUM)
        {
            subCost.sprite = trueStar;
        }
    }
}
