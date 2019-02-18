using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JihankiTouch : MonoBehaviour {
    [SerializeField]
    private GameObject Textobj;
    private GameObject gameObject;
    private JihnakiText Jtext;
    private Vector3 pos;
    [SerializeField]
    private Transform Parent;

    [SerializeField]
    private GameObject Tenant2;
    private MoneySeisei moneySeisei;

    private MoneyManager moneyManager;

	// Use this for initialization
	void Start () {
        pos = this.transform.position;
        moneySeisei = Tenant2.GetComponent<MoneySeisei>();
        moneyManager = GameObject.Find("GameManager").GetComponent<MoneyManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Form()
    {
        gameObject = (GameObject)Instantiate(Textobj, new Vector3(pos.x, pos.y + 30.0f, pos.z), Quaternion.identity, Parent);
        Jtext = gameObject.GetComponent<JihnakiText>();
        Text text = gameObject.GetComponent<Text>();
        float money = Mathf.Round(UnityEngine.Random.Range(0.0f, 4.9f));
        Debug.Log(money);
        if (money >= 1)
        {
            moneyManager.TouchGetMoney(money);
        }
        //float money = moneySeisei.JihankiTouchGet();
        text.text = "￥" + money;
    }
}
