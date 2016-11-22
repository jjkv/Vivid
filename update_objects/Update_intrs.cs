//Script for updating 'interacts'
//Objects which use gravity and are affected by external forces.
//Script handles switching between physics properties
//of the objects based on their 'color'
//on_change is called by the colour_change script.
using UnityEngine;
using System.Collections;

public class Update_intrs : MonoBehaviour {

	private Rigidbody rb;
	private CapsuleCollider collided;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	//called by colour_change, passed the transform 'rend' of an object
	//resets the objects physics to base for the intrs type
	//calls appropriate physics func based on the objects color.
	public void on_change(Transform rend)
	{
		restore (rend);
		Color obj_color = rend.GetComponent<Renderer> ().material.color;
		if (obj_color == Color.white)
			return;
		else if (obj_color == Color.red)
			red_phys (rend);
		else if (obj_color == Color.blue)
			blue_phys (rend);
		else if (obj_color == Color.green)
			green_phys (rend);
		else if (obj_color == Color.cyan)
			cyan_phys (rend);
		else if (obj_color == Color.magenta)
			magenta_phys (rend);
		else if (obj_color == Color.yellow)
			yellow_phys (rend);
		else if (obj_color == Color.black)
			return;
	}

	//function that restores object to blank slate
	void restore( Transform rend)
	{
		rb = rend.GetComponent <Rigidbody> ();
		collided = rend.GetComponent<CapsuleCollider> ();
		collided.isTrigger = false;
		rb.constraints = RigidbodyConstraints.None;
		rb.useGravity = true;
		rb.isKinematic = false;

	}

	void red_phys(Transform rend)
	{

		//Component bouncer = rend.GetComponent<Bounce>;
		//if (bouncer != null)
		//	bouncer. ();


	}

	void blue_phys(Transform rend)
	{




	}

	void green_phys(Transform rend)
	{



	}

	//holographic
	void yellow_phys(Transform rend)
	{

		collided.isTrigger = true;

	}

	//stop moving
	void cyan_phys(Transform rend)
	{
		rb.constraints = RigidbodyConstraints.FreezeAll;

	}

	void magenta_phys(Transform rend)
	{


	}
}