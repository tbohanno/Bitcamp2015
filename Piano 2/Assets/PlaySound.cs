using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	public float semitone_offset = 0;
	public int collisions = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		PlayNote ();
	}
	

	void OnCollisionEnter(Collision col) {
		PlayNote ();
	}

	void PlayNote () {
		GetComponent<AudioSource> ().pitch = Mathf.Pow (2f, semitone_offset/12.0f);
		GetComponent<AudioSource> ().Play();
	}
	
}