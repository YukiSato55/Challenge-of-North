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

	public void ChangeMusicVolume(float vol){
		Debug.Log (vol);
		gameObject.GetComponent<AudioSource> ().volume = vol/10;
		//mixer.SetFloat ("MusicVolume", vol);
	}

	public void ChangeSfxVolume(float vol){
		mixer.SetFloat ("SfxVolume", vol);
	}


	public float masterVolume {
		set {
			mixer.SetFloat ("MasterVolume", Mathf.Lerp (-80, 0, value));
		}
	}
}