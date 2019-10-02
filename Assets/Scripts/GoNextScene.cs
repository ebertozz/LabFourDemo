using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoNextScene : MonoBehaviour {

	// Use this for initialization
	public Button NextLevel;  // reference to button
	public GameObject motherShip; // referece to motherShip object
	public SpacemanControl spacemanControl; // reference to script storing the score

	// Use this for initialization
	void Start () {
		NextLevel.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (motherShip == null) {  // see if motherShip has been destroyed
			NextLevel.gameObject.SetActive(true);
		}
	}

	public void LoadNextScene(){

		PlayerPrefs.SetInt ("Score", spacemanControl.orbHits); // save the current value of orbHits
		SceneManager.LoadScene ("_Scene_1");

	}
}
