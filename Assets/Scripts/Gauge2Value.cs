using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge2Value : MonoBehaviour {

    private float HP, maxHP, alphaMax, alpha, alphaTimeMax, alphaTime;
    private AlphaColor alphaColor;
    private LineRenderer lineRenderer, Backline;
    private Material mate;
    public Shader sh;
    [SerializeField]
    private GameObject Back;

    Color color;

	// Use this for initialization
	void Start () {
        HP = GetComponentInParent<MonsterStatus>().MonsHP;
        lineRenderer = GetComponent<LineRenderer>();
        Backline = Back.GetComponent<LineRenderer>();
        maxHP = HP;
        alphaMax = 1;
        alpha = alphaMax;
        alphaTimeMax = 1;
        alphaTime = alphaTimeMax;

        mate = new Material(sh);
        mate.SetColor("_TintColor", new Color(0.5f,0.5f,0.5f, alpha));
        lineRenderer.sharedMaterial = mate;
        Backline.sharedMaterial = mate;
        //Debug.Log(lineRenderer);
    }
	
	// Update is called once per frame
	void Update () {
        
        if (alphaTime <= 0)
        {
            alpha -= 0.01f;
            mate.SetColor("_TintColor", new Color(0.5f, 0.5f, 0.5f, alpha));
            lineRenderer.sharedMaterial = mate;
            Backline.sharedMaterial = mate;
        } else
        {
            alphaTime -= Time.deltaTime;
        }
    }

    public void GaugeDamage()
    {
        
        HP = GetComponentInParent<MonsterStatus>().MonsHP;
        lineRenderer.SetPosition(1, new Vector3(Mathf.Clamp01((float)HP / (float)maxHP)-0.5f, 0.2f, 0f));
        alpha = alphaMax;
        mate.SetColor("_TintColor", new Color(0.5f, 0.5f, 0.5f, alpha));
        lineRenderer.sharedMaterial = mate;
        Backline.sharedMaterial = mate;
        alphaTime = alphaTimeMax;
    }
    
}
