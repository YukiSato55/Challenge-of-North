using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTouch : MonoBehaviour {
    private float MoneyPercent;
    [SerializeField]
    private GameObject man, oku;

    private Image image;

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateDisplay(float Nowmoney, float Max)
    {
        MoneyPercent = Nowmoney / Max;
        if(MoneyPercent >= 0.6f)
        {
            oku.SetActive(true);
            man.SetActive(false);
            image.color = new Color(1, 1, 1, 1);

        }
        else if(Nowmoney != 0)
        {
            oku.SetActive(false);
            man.SetActive(true);
            image.color = new Color(1, 1, 1, 1);

        }
        else if(MoneyPercent == 0)
        {
            oku.SetActive(false);
            man.SetActive(false);
            image.color = new Color(1, 1, 1, 0);
        }
    }
}
