using UnityEngine;
using System.Collections;

public class musicMngr : MonoBehaviour {
	public AudioSource theme;

	public AudioSource c_loop;
	public AudioSource r_loop;
	public AudioSource g_loop;
	public AudioSource b_loop;
	public AudioSource bang;
	// Use this for initialization
	void Start () {
		theme.Play ();
		theme.volume = 0.5f;
		c_loop.Play ();
		c_loop.volume = 0.0f;
		r_loop.Play ();
		r_loop.volume = 0.0f;;
		g_loop.Play ();
		g_loop.volume = 0.0f;
		b_loop.Play ();
		b_loop.volume = 0.0f;
	}
	
	// Update is called once per frame
	public void updateMusic(Color c) {
		bang.Stop ();
		bang.Play ();
		if (c == Color.white) {
			if (c_loop.volume == 0) {
				c_loop.volume = 0.5f;
				r_loop.volume = 0.0f;
				g_loop.volume = 0.0f;
				b_loop.volume = 0.0f;
			} else {
				c_loop.volume = 0.0f;
			}
		} else if (c == Color.red) {
			if (r_loop.volume == 0) {
				r_loop.volume = 0.5f;
				c_loop.volume = 0.0f;
				g_loop.volume = 0.0f;
				b_loop.volume = 0.0f;
			} else {
				r_loop.volume = 0.0f;;
			}
		} else if (c == Color.green) {
			if (g_loop.volume == 0) {
				g_loop.volume = 0.5f;
				r_loop.volume = 0.0f;
				c_loop.volume = 0.0f;
				b_loop.volume = 0.0f;
			} else {
				g_loop.volume = 0.0f;;
			}
		} else if (c == Color.blue) {
			if (b_loop.volume == 0) {
				b_loop.volume = 0.5f;
				r_loop.volume = 0.0f;
				g_loop.volume = 0.0f;
				c_loop.volume = 0.0f;
			} else {
				b_loop.volume = 0.0f;
			}
		}
	}
}
