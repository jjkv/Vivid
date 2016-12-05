using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class audioCollisionMngr : MonoBehaviour {

	Dictionary<Color, AudioSource> soundTable = new Dictionary<Color, AudioSource>();

	public AudioSource red_sound;
	public AudioSource blue_sound;
	public AudioSource yellow_sound;
	public AudioSource magenta_sound;

	// Use this for initialization
	void Start () {
		soundTable [Color.red] = red_sound;
		soundTable [Color.blue] = blue_sound;
		soundTable [Color.yellow] = yellow_sound;
		soundTable [Color.magenta] = magenta_sound;
	}

	bool inDict(Color c) {
		return ((c == Color.red)    	||
				(c == Color.blue)   	||
				(c == Color.yellow) 	||
				(c == Color.magenta));
	}

	public void playColorClip(Color c) {
		if (inDict (c)) {
			(soundTable [c]).Play ();
		}
	}

	public void stopColorClip(Color c) {
		if (inDict (c)) {
			if ((soundTable [c]).loop) {
				(soundTable [c]).Stop ();
			}
		}
	}

}
