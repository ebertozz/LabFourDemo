using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour {

	public GameObject orbPrefab; // var to hold prefab for instantiating orbs

	public float speed = 10f; // speed ship is moving
	float leftRightEdges = 8f; // distance before the ship changes direction

	float chanceDirectionChange = 0.04f; // how likely ship will change direction

	public float secsBetweenLaunch = 0.5f; // rate that we generate orbs from the ship



	// on start we want orbs to start falling from the ship
	void Start () {
		InvokeRepeating ("LaunchOrb", 4f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
	}
	
	// move the ship and randomly change direction while game is running
	void Update () {

		Vector3 pos = transform.position; // create a var to hold current position
		pos.x += speed * Time.deltaTime; // sets the xpos of our ship to the speed var * sec since last frame
		transform.position = pos;

		if (pos.x < -leftRightEdges) { // if the ship pos is less than -10 set speed to a pos number
			speed = Mathf.Abs (speed); 
		} else if (pos.x > leftRightEdges) {
		
			speed = -Mathf.Abs (speed);  // if the ship pos x is greater than 10 reverse speed
		}

	}

	void FixedUpdate(){
	 
		if (Random.value < chanceDirectionChange) {  // change direction at a random interval
			speed *= -1;
		
		}
	
	}

	void LaunchOrb(){
	
		GameObject orb = Instantiate (orbPrefab) as GameObject; // create reference to hold game object
		orb.transform.position = transform.position;
	
	}


}
