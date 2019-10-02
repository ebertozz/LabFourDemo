using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SceneOneManager : MonoBehaviour {

	int previousScore;  // create a basket to hold score from previous scene
	public Text tellScore; // create a text field to display score

	// Use this for initialization
	void Start () {
		previousScore = PlayerPrefs.GetInt ("Score", 0);  // set the value of my var to the stored value from pre. scene
		tellScore.text = "Score from previous level: " + previousScore.ToString (); //

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
