﻿using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		PlayNote ();
	}

	void PlayNote () {
		GetComponent<AudioSource> ().Play ();
	}
}
