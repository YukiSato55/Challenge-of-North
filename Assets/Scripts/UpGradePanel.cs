using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpGradePanel : MonoBehaviour {
    //private GameObject FormPosObj;
    private Vector3 FormPos;
    private Image Panelimage, SourceImage;
    private StatusDataBase statusData;
    private Slider HP, NextHP;
    private Slider ATK, NextATK;
    private Text HPText, PlusHPText;
    private Text ATKText, PlusATKText;

    // Use this for initialization
    void Start() {
        FormPos = GameObject.Find("FormPos").transform.position;
        Panelimage = GetComponent<Image>();
        statusData = GameObject.Find("MonsStatusDatabase").GetComponent<StatusDataBase>();
        HP = GameObject.Find("HP").GetComponent<Slider>();
        NextHP = GameObject.Find("NextHP").GetComponent<Slider>();
        ATK = GameObject.Find("ATK").GetComponent<Slider>();
        NextATK = GameObject.Find("NextATK").GetComponent<Slider>();

        HPText = GameObject.Find("HPText").GetComponent<Text>();
        PlusHPText = GameObject.Find("NextHPText").GetComponent<Text>();
        ATKText = GameObject.Find("ATKText").GetComponent<Text>();
        PlusATKText = GameObject.Find("NextATKText").GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick(int ID)
    {
        int Rank;

        if(PlayerPrefs.HasKey("MonsRank_" + ID))
        {
            Rank = PlayerPrefs.GetInt("MonsRank_" + ID);
            NextHP.maxValue = 300;
            NextATK.maxValue = 100;
            NextHP.value = statusData.MonsDataHP[ID, Rank + 1];
            NextATK.value = statusData.MonsDataATK[ID, Rank + 1];
            HP.value = statusData.MonsDataHP[ID, Rank];
            ATK.value = statusData.MonsDataATK[ID, Rank];
            //お値段各場所予定地
            HPText.text = "+" + (int)statusData.MonsDataHP[ID, Rank];
            HPText.text = "+" + (int)statusData.MonsDataHP[ID, Rank];

        }
    }
}
