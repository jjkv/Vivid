using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

	private bool bounce = false;
	public bool is_on = false;
	private float bounceHeight = 10;
	public Transform Player;

	public void bounce_on()
	{
		is_on = true;
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		if (bounce) 
		{
			Vector3 velocity = Player.GetComponent<Rigidbody>().velocity;
			Player.GetComponent<Rigidbody>().velocity = new Vector3(velocity.x, 0, velocity.z);
			Player.GetComponent<Rigidbody>().AddForce (0, bounceHeight, 0, ForceMode.Impulse);
			bounce = false;
		}
	}

	void OnCollisionEnter (Collision other)
	{
		if (is_on) {
		//	if (other.gameObject.tag == "Player") {
				bounce = true;
			}
		//}
	}
}