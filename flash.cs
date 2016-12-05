// this doesn't look great, but it's a start
// make a point light as the child of the lamp's point light
// and assign it to the flashLight variable. put this script
// on the character capsule object, then give the colour_change
// script the character in the flash script field.

using UnityEngine;
using System.Collections;

public class flash : MonoBehaviour {

	private Color sentinel;
	public bool flashing;
	public Light flashLight;

	void Start () {
		flashLight.range = 0;
		flashLight.intensity = 8;
		flashLight.bounceIntensity = 8;
		flashing = false;
		sentinel = Color.gray;
		flashLight.color = sentinel;
	}

	public void initFlash (Color c) {
		flashing = true;
		flashLight.color = c;
		flashLight.range = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (flashing) {
			flashLight.range += 10;
			if (flashLight.range >= 100) {
				flashing = false;
				flashLight.range = 0;
			}
		}
	}
}
