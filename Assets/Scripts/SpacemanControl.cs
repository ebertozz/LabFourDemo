using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpacemanControl : MonoBehaviour {

	public Text playerMessage; // var to talk to text field;
	 public int orbHits = 0;  // number of times astro hits orb 

	public GameObject motherShip; // a reference to the mothership game object so we teleport astro to the ship

public AudioClip impactSound; // reference to audio clip
private AudioSource impactSource; //reference to audio source

void Awake(){
impactSource = GetComponent<AudioSource>();
	
}

	
	// Update is called once per frame
	void Update () {

		Vector3 mousePos2D = Input.mousePosition;  // get current mousePos

		mousePos2D.z = Camera.main.transform.position.z; // Camera z pos to convert to 2d

		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D); // convert 2D 3D

		// set x pos of Astro to the x postion of the mouse

		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;
	}


	void OnCollisionEnter2D(Collision2D other){
	
		orbHits++;
		impactSource.PlayOneShot(impactSound,1f);
		playerMessage.text = "you hit me" + orbHits;

		if (orbHits > 5) {

			playerMessage.text = "I'm going home";
			Vector2 mothershipPos = motherShip.transform.position;  // where the ship is now
			transform.position = mothershipPos;  // move Astro to that position
			Destroy (motherShip);
			Destroy (gameObject, 2.5f);

		}
	
	}

}
