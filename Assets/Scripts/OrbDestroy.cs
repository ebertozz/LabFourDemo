using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbDestroy : MonoBehaviour {

	public static float floorY = -6f;  //  where do we want orb to disappear


	
	// When orb falls below floor, destroy it.
	void Update () {

		if (transform.position.y < floorY) {
		
			Destroy (this.gameObject);
		}

	}
}
