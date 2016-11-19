using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManagment : MonoBehaviour {
	public bool paused = false;
	public Canvas pauseUI;

	public int numScenes = 4;
	public string[] scenes;
	public CrankyRigidBodyController player;

	private int curr_scene = 0;

	// Use this for initialization
	void Start () {
		scenes = loadSceneArray ();
	}

	string[] loadSceneArray() {
		string[] s = new string[numScenes];
		s [0] = "_scenes/jump_tutorial";
		s [1] = "_scenes/red_tutorial";
		s [2] = "_scenes/green_tutorial";
		s [3] = "_scenes/blue_tutorial";
		return s;
	}

	void load(int i) {
		SceneManager.LoadScene (scenes[i]);
	}
	
	// Update is called once per frame
	void Update () {
		curr_scene = SceneManager.GetActiveScene().buildIndex;
		if (player.isDead) {
			load (curr_scene);
		} else if (player.isFinished) {
			curr_scene += 1;
			player.isFinished = false;
			player.isDead = false;
			load (curr_scene);
		}

		if (Input.GetKey (KeyCode.Escape)) {
			if (!paused) {
				pauseUI.enabled = true;
				paused = true;
				Time.timeScale = 0f;
			} else {
				pauseUI.enabled = false;
				paused = false;
				Time.timeScale = 1f;
			}
		}
	}

	/* MAIN MENU BUTTON FUNCTIONS!!! */

	public void exit_button() {
		Application.Quit ();
	}

	public void newg_button() {
		SceneManager.LoadScene(scenes[0]);
	}

	public void cont_button() {
		SceneManager.LoadScene(scenes[3]);
	}

	public void opt_button() {
		/* load options scene */
	}

	/* PAUSE MENU BUTTON FUNCTIONS */
	public void resume_button() {
		Time.timeScale = 1;
	}

	public void resest_button() {
		load (SceneManager.GetActiveScene ().buildIndex);
	}

	public void mMenu_button() {
		/* load main menu scene */
	}

}
