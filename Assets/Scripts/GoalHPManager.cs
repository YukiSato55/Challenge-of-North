using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalHPManager : MonoBehaviour {
    [SerializeField]
    private float HP;
    private Slider slider;
    private bool clearflug = false;
    private ResultManager resultManager;

	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
        slider.maxValue = HP;
        slider.value = HP;
        resultManager = GameObject.Find("ResultManager").GetComponent<ResultManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DamageCalculation(float MonsATK)
    {
        slider.value -= MonsATK;
        if (slider.value <= 0)
        {
            slider.value = 0;
            if (clearflug == false)
            {
                resultManager.MainBreak();
                clearflug = true;
            }
        }
    }
}
