using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JihnakiText : MonoBehaviour {
    private Text text;
    private Outline outline;
    private float alpha;
    [SerializeField]
    private Vector3 pos;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        outline = GetComponent<Outline>();
        alpha = 1f;
        Debug.Log(text);
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(alpha);
        if (alpha > 0) {
            alpha -= 0.05f;
            text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
            outline.effectColor = new Color(outline.effectColor.r, outline.effectColor.g, outline.effectColor.b, alpha-0.1f);
        } else
        {
            Destroy(this.gameObject);
        }
        this.gameObject.transform.Translate(0f, 0.2f, 0f);

	}
}
