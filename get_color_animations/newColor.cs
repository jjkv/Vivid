using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class newColor : MonoBehaviour {


	public Light progress;

	public int count = 0;
	public float PULSE_RANGE = 5.0f;
	public float PULSE_SPEED = 3.0f;
	public float PULSE_MIN = 1.0f;
	public bool fading = false;
	public bool lighting = false;

	delegate bool eventMethod();
	List<eventMethod> events = new List<eventMethod> ();
	private int e = 0;

	public Light lamp;
	public Light area;

	public CrankyRigidBodyController movement;
	public SimpleSmoothMouseLook vision;
	public colour_change change;

	private float fadeFrom = 0.0f;
	private float fadeTo = 0.0f;
	private float fadeTime = 3;

	public Light flame;
	private Vector3 descent;
	private float flameSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		events.Add (moveFlame);
		events.Add (pulseFlame);
		events.Add (flareOut);
		events.Add (flareIn);
		events.Add (pulseFlame);
		events.Add (lightLamp);
		events.Add (fadeInLamp);
		events.Add (fadeInProgress);
		events.Add (playerOn);
		events.Add (sentinel);
		descent.x = 0;
		descent.y = 4;
		descent.z = 50;

		movement.enabled = false;
		vision.enabled = false;
		change.enabled = false;
		lamp.intensity = 1;
		area.intensity = 1;
		progress.intensity = 0;
	}

	bool waitForFrames () {
		count += 1;
		if (count > 60) {
			return true;
		} else {
			return false;
		}
	}

	bool moveFlame () {
		flameSpeed += 0.05f;
		float step = flameSpeed * Time.deltaTime;
		flame.transform.position = Vector3.MoveTowards (flame.transform.position, descent, step);
		if (flame.transform.position == descent) {
			return true;
		} else {
			return false;
		}
	}

	bool pulseFlame () {
		count += 1;
		if (count < 400) {
			flame.range = PULSE_MIN + Mathf.PingPong (Time.time * PULSE_SPEED, PULSE_RANGE - PULSE_MIN);
			return false;
		} else {
			flame.range = 1;
			count = 0;
			return true;
		}
	}

	bool flareOut () {
		flame.range += 10;
		if (flame.range >= 1500) {
			return true;
		} else {
			return false;
		}
	}

	bool flareIn () {
		flame.range -= 20;
		if (flame.range <= 1) {
			flame.range = 1;
			return true;
		} else {
			return false;
		}
	}

	void startFade () {
		fadeFrom = Time.time;
		fadeTo = fadeFrom + fadeTime;
		fading = true;
		if (change.r_enabled) {
			lamp.color = Color.red;
		} else if (change.g_enabled) {
			lamp.color = Color.green;
		} else if (change.b_enabled) {
			lamp.color = Color.blue;
		}
	}

	bool fadeInLamp () {
		if (!(fading)) {
			startFade ();
		}

		lamp.intensity = Mathf.InverseLerp (fadeFrom, fadeTo, Time.time);
		area.intensity = Mathf.InverseLerp (fadeFrom, fadeTo, Time.time);
		if (lamp.intensity >= 1 && area.intensity >= 1) {
			fading = false;
			return true;
		} else {
			return false;
		}
	}

	bool fadeInProgress () {
		if (!(fading)) {
			startFade ();
		}

		progress.intensity = Mathf.InverseLerp (fadeFrom, fadeTo, Time.time);
		if (progress.intensity >= 1) {
			fading = false;
			return true;
		} else {
			return false;
		}
	}

	void startLight () {
		fadeFrom = flame.range;
		fadeTo = 0;
		lighting = true;
	}

	bool lightLamp () {
		flameSpeed -= 0.1027f;
		float step = flameSpeed * Time.deltaTime;
		flame.transform.position = Vector3.MoveTowards (flame.transform.position, lamp.transform.position, step);
		// needs to be less jank, use lerp
		flame.range -=.005f;
		if (flame.transform.position == lamp.transform.position) {
			Destroy (flame);
			return true;
		} else {
			return false;
		}
	}

	bool playerOn() {
		movement.enabled = true;
		vision.enabled = true;
		change.enabled = true;
		return true;
	}

	bool sentinel() {
		return false;
	}

	void LateUpdate () {

		if (events [e] ()) {
			e += 1;
		}
	}
}
