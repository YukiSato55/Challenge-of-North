using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMenu : MonoBehaviour {
    [SerializeField]
    private GameObject mainpanel;
    private bool PauseFlug;

	// Use this for initialization
	void Start () {
        PauseFlug = false;
	}
	
	// Update is called once per frame
	void Update () {
        /*
		if(PauseFlug == true)
        {
            Pause();
        } else
        {
            RePause();
        }
        */
	}

    public void ActivePanel()
    {
        mainpanel.SetActive(true);
        Pause();
        //PauseFlug = true;
    }

    public void NonActivePanel()
    {
        mainpanel.SetActive(false);
        RePause();
        //PauseFlug = false;
    }

    public static void Pause()
    {
        Time.timeScale = 0;
    }

    public static void RePause()
    {
        Time.timeScale = 1.0f;
    }

    public void Simpledelete()
    {
        mainpanel.SetActive(false);
    }

    public void Simplediside()
    {
        mainpanel.SetActive(true);
    }

    public void GiveNonActive(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void GiveActive(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
}
