using UnityEngine;
using System.Collections;

public class freezeRigidBody : MonoBehaviour {

	void Start () {
		transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
	}
}
