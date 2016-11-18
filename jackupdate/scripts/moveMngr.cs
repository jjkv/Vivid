using UnityEngine;
using System.Collections;

public class moveMngr : MonoBehaviour {

	public CrankyRigidBodyController script;

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.GetComponent<Renderer> ().material.color == Color.blue) {
			movement_blue ();
		} else if (collision.gameObject.GetComponent<Renderer> ().material.color == Color.yellow) {
			movement_yellow ();
		} else if (collision.gameObject.GetComponent<Renderer> ().material.color == Color.magenta) {
			movement_magenta ();
		}
	}

	void OnCollisionExit (Collision collision) {
		movement_exit ();
	}

	// speed
	public void movement_blue () {
		script.MovementSpeed = 700.0f;
	}

	// holo
	public void movement_yellow () {
		this.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;
	}

	public void movement_magenta () {
		script.enabled = false;
	}

	public void movement_exit()
	{
		script.enabled = true;
		script.MovementSpeed = 7.0f;
		this.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
	}
}