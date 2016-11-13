using UnityEngine;
using System.Collections;

public class conserveMomentum : MonoBehaviour {

	float impactSpeed = 0.0f;
	bool collided = false;
	float accel = 30.0f;
	Rigidbody rb;

	// Update is called once per frame
	void Start () {
		rb = transform.GetComponent<Rigidbody> ();
		rb.useGravity = false;
		rb.constraints = RigidbodyConstraints.FreezeRotation;
	}

	void OnCollisionEnter(Collision c) {
		impactSpeed = c.relativeVelocity.magnitude;
		collided = true;
	}

	void FixedUpdate () {
		if (collided == true) {
			if (rb.velocity.magnitude < impactSpeed) {
				rb.AddRelativeForce (Vector3.forward * accel);
			}
		}
	}
}