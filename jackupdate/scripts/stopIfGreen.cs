using UnityEngine;
using System.Collections;

public class stopIfGreen : MonoBehaviour {

       void OnCollisionEnter (Collision collision) {
       	    if (collision.gameObject.GetComponent<Renderer> ().material.color == Color.green) {
	       						    this.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;
							    				 }
											 }
}
