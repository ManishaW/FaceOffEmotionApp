using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {

	private double y1, y2;
	public GameObject placeholder; 
	private Rigidbody2D expressionEmoji;
	private PlayerEmotions result;
	private Score playerScore; 

	// Use this for initialization
	void Start () {
		y1 = -3;
		y2 = -5.34;
		expressionEmoji = placeholder.GetComponent<Rigidbody2D>();
		result = GetComponent<PlayerEmotions>();
		playerScore = GameObject.FindGameObjectWithTag ("score").GetComponent<Score> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (expressionEmoji.position.y < y1 && expressionEmoji.position.y > y2) {
			Debug.Log ("It's in bounds! It's" + result.getResult ());
			playerScore.addScore (10);
		}
		//else
		//	Debug.Log ("It's not :(.");
	}
}
