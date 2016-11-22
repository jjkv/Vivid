//Script for updating 'platforms'
//Objects which ignore gravity and ignore external forces.
//Script handles switching between physics properties
//of the objects based on their 'color'
//on_change is called by the colour_change script.
using UnityEngine;
using System.Collections;

public class Update_plats : MonoBehaviour {
	private Rigidbody rb;
	private BoxCollider collided;
	public CrankyRigidBodyController script;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	//called by colour_change, passed the transform 'rend' of an object
	//resets the objects physics to base for the plats type
	//calls appropriate physics func based on the objects color.
	public void on_change(Transform rend)
	{
		script.enabled = true;
		script.MovementSpeed = 7.0f;
		rb = rend.GetComponent <Rigidbody> ();
		collided = rend.GetComponent<BoxCollider> ();
		collided.isTrigger = false;
		rb.constraints = RigidbodyConstraints.None;
		rb.useGravity = true;
		Color obj_color = rend.GetComponent<Renderer> ().material.color;

		collided.material = new PhysicMaterial ("init");
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

	/*void restore(transform rend)
	{
		script.enabled = true;
		script.MovementSpeed = 7.0f;
		rb = rend.GetComponent <Rigidbody> ();
		collided = rend.GetComponent<BoxCollider> ();
		collided.isTrigger = false;
		rb.constraints = RigidbodyConstraints.None;
		rb.useGravity = true;
	}
	*/
	// bounce
	void red_phys(Transform rend)
	{

		collided.material = new PhysicMaterial("bounce");
		collided.material.bounciness = 1.0f;
		collided.material.bounceCombine = PhysicMaterialCombine.Maximum;
	}

	// speed
	void blue_phys(Transform rend)
	{
		script.triggerCollision ();
	}

	// holographic
	void green_phys(Transform rend)
	{
		collided.isTrigger = true;
	}

	// sticky
	void yellow_phys(Transform rend)
	{
		script.triggerCollision ();
	}

	//stop moving
	void cyan_phys(Transform rend)
	{
		rb.constraints = RigidbodyConstraints.FreezeAll;
	}

	// slide
	void magenta_phys(Transform rend)
	{
		collided.material = new PhysicMaterial("slide");
		collided.material.dynamicFriction = 0.0f;
		collided.material.staticFriction = 0.0f;
		collided.material.frictionCombine = PhysicMaterialCombine.Minimum;

		script.triggerCollision ();
	}
}