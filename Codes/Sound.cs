using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
	public AudioClip[] audioClip;

	void PlaySound(int clip)
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.clip = audioClip[clip];
		audio.Play ();
	}﻿

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			PlaySound(0);
		}
	}
}
