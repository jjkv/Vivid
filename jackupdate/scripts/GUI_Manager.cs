using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUI_Manager : MonoBehaviour {

	public bool enabled;

	public Light lite;

	public Image reticle;
	public Image color_checker; 

	public Sprite reticleNorm;
	public Sprite reticleClick;
	public Sprite no_lens;
	public Sprite red_lens;
	public Sprite blue_lens;
	public Sprite green_lens;

	void Start () {
		if (enabled) {
			reticle.sprite = reticleNorm;
			color_checker.sprite = no_lens;
		}
	}


	// Update is called once per frame
	void LateUpdate () {
		if (enabled) {
			if (Input.GetMouseButton (0)) {
				reticle.sprite = reticleClick;
			} else {
				reticle.sprite = reticleNorm;
			}

			if (lite.color == Color.white) {
				color_checker.sprite = no_lens;
			} else if (lite.color == Color.red) {
				color_checker.sprite = red_lens;
			} else if (lite.color == Color.green) {
				color_checker.sprite = green_lens;
			} else if (lite.color == Color.blue) {
				color_checker.sprite = blue_lens;
			}
			
			if (Input.GetKeyDown (KeyCode.C)) {
				color_checker.sprite = red_lens;
			} else if (Input.GetKeyDown (KeyCode.V)) {
				color_checker.sprite = blue_lens;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				color_checker.sprite = green_lens;
			} else if (Input.GetKeyDown (KeyCode.N)) {
				color_checker.sprite = no_lens;
			}
		}
	}
}
