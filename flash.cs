using UnityEngine;
using System.Collections;

public class flash : MonoBehaviour {
	private Vector3 sphereAccel = new Vector3(5.0f, 5.0f, 5.0f);
	private int lightAccel = 10;
	private int lightBoundry = 200;

	private Color sentinel;
	public bool flashing;
	public Light flashLight;
	public GameObject flashSphere;

	void Start () {
		flashSphere.GetComponent<Transform> ().localScale = new Vector3 (0.0f, 0.0f, 0.0f);
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
		flashSphere.GetComponent<Renderer> ().material.SetColor ("_TintColor", c);
		flashSphere.GetComponent<Transform> ().localScale = new Vector3 (0.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (flashing) {
			flashLight.range += lightAccel;
			flashSphere.GetComponent<Transform> ().localScale += sphereAccel;
			if (flashLight.range >= lightBoundry){
				flashing = false;
				flashLight.range = 0;
				flashSphere.GetComponent<Transform> ().localScale = new Vector3 (0.0f, 0.0f, 0.0f);
			}
		}
	}
}
