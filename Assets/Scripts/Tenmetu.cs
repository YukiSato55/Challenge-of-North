using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tenmetu : MonoBehaviour {
    private float a_color, r, g, b;
    private float EffectSpeed;
    private bool InvisibleFlug; // true: up, false: down

	// Use this for initialization
	void Start () {
        r = GetComponent<Outline>().effectColor.r;
        g = GetComponent<Outline>().effectColor.g;
        b = GetComponent<Outline>().effectColor.b;
        a_color = 0f;
        EffectSpeed = 0.03f;
        InvisibleFlug = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (InvisibleFlug)
        {
            a_color += EffectSpeed;
            if (a_color >= 1f) InvisibleFlug = false;
        } else
        {
            a_color -= EffectSpeed;
            if (a_color <= 0f) InvisibleFlug = true;
        }
        GetComponent<Outline>().effectColor = new Color(r, g, b, a_color);
	}
}
