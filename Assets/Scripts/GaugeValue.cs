using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeValue : MonoBehaviour {
    private Slider slider;
    private float HP;
    private AlphaColor alphaColor;

	// Use this for initialization
	void Start () {
        slider = this.GetComponent<Slider>();
        HP = this.GetComponentInParent<MonsterStatus>().MonsHP;
        slider.maxValue = HP;
        slider.value = HP;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GaugeDamage()
    {
        HP = this.GetComponentInParent<MonsterStatus>().MonsHP;
        slider.value = HP;
        for (int i = 0; i < transform.childCount; i++)
        {
            Debug.Log(i);
            if (transform.GetChild(i).GetComponent<AlphaColor>() != null)
            {
                transform.GetChild(i).GetComponent<AlphaColor>().Reset();
            }
        }
    }
}
