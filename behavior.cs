using UnityEngine;
using System.Collections;

public class behavior : MonoBehaviour {
	private bool move;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		move = true;rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (move == true)
			rb.MovePosition (transform.position + transform.forward*Mathf.Cos(Time.time)*3 * Time.deltaTime);
			//transform.Translate(transform.forward*Mathf.Cos (Time.time)*Time.deltaTime);
	}

	//NOT WORKING
//	void OnCollisionEnter(Collision collision)
//	{
//		print ("foo\n");
//		if (collision.gameObject.tag == "Player")
//			print ("foo\n");
//			collision.transform.SetParent (transform);

//	}

	//void OnCollisionExit(Collision collision)
	//{
	//	if (collision.gameObject.tag == "Player")
	//		collision.transform.SetParent (null);

	//}
}
