using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSurprise : MonoBehaviour {

	public PlayerEmotions result;
	private string expectedResult = "Surprise";

	// Use this for initialization
	void Start () {
		result = GetComponent<PlayerEmotions>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if (result.getResult().Equals (expectedResult)) {
			Debug.Log ("It's in bounds! It's" + result.getResult ());
		}

		Debug.Log ("Your expression " + result.getResult());
		Debug.Log ("Increase score.");
	}
}

