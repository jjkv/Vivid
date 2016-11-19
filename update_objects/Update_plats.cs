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
			white_phys (rend);
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
			black_phys (rend);
	}

	void white_phys(Transform rend)
	{




	}

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

	// holo
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

	void black_phys(Transform rend)
	{


	}
}