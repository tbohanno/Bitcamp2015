using UnityEngine;
using System.Collections;

public class PlayPianoSound : MonoBehaviour {

	public float semitone_offset = 0;
	public int collisions = 0;
	public double timer = 0.0;

	void OnMouseDown () {
		PlayNote ();
	}

	void OnCollisionExit(Collision col) {
		collisions --;
	}

	void OnCollisionEnter(Collision col) {
		if (IsHand(col) && col.gameObject.name == "bone2" && (collisions <=0 || Time.time - timer > 1)) {
			timer = Time.time;
			collisions = 0;
			PlayNote ();
		}
		collisions ++;
	}

	void PlayNote () {
		GetComponent<AudioSource> ().pitch = Mathf.Pow (2f, semitone_offset/12.0f);
		GetComponent<AudioSource> ().Play();
	}

	private bool IsHand(Collision other)
	{
		if (other.transform.parent && other.transform.parent.parent &&     other.transform.parent.parent.GetComponent<HandModel>())
			return true;
		else
			return false;
	}
	
}