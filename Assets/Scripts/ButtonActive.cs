using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActive : MonoBehaviour {
    [SerializeField] // 表示非表示換える用
    private GameObject obj;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Active()
    {
        obj.SetActive(true);
    }

    public void Inactive() // 非表示用
    {
        obj.SetActive(false);
    }

}
