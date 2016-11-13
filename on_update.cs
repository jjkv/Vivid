using UnityEngine;
using System.Collections;

public class on_update : MonoBehaviour {
	private Rigidbody rb;
	private BoxCollider collided;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void on_change(Transform rend)
	{
		rb = rend.GetComponent <Rigidbody> ();
		collided = rend.GetComponent<BoxCollider> ();
		collided.isTrigger = false;
		rb.constraints = RigidbodyConstraints.None;
		Color obj_color = rend.GetComponent<Renderer> ().material.color;
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

	void black_phys(Transform rend)
	{


	}
}
