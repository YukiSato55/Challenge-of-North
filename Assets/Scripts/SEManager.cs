using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SEManager : MonoBehaviour {
	
    private AudioSource GetSE;

	UnityEngine.Audio.AudioMixer mixer;

	// Use this for initialization
	void Start () {
        GetSE = GetComponent<AudioSource>();



	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        //Debug.Log("音なるで");
        GetSE.PlayOneShot(GetSE.clip);
    }

    public void GiveOnClick(AudioClip SE)
    {
        GetSE.PlayOneShot(SE);
    }

	public void ChangeMusicVolume(float vol){
		Debug.Log (vol);
		gameObject.GetComponent<AudioSource> ().volume = vol/10;
		//mixer.SetFloat ("MusicVolume", vol);
	}

	public void ChangeSfxVolume(float voll){
		Debug.Log (voll);
		gameObject.GetComponent<AudioSource> ().volume = voll/10;
		//mixer.SetFloat ("SfxVolume", vol);
	}
    // BGM,SEの音量数値を保存して、他のシーンでも使える様に

	public float masterVolume {
		set {
			mixer.SetFloat ("MasterVolume", Mathf.Lerp (-80, 0, value));
		}
	}
}