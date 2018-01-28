using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerAngry : MonoBehaviour {

	private string expectedResult = "Anger";
	Text textArea;
	private Score playerScore; 
	public Text score;

	// Use this for initialization
	void Start () {
		textArea = GameObject.Find ("EmotionDisplay").GetComponent<Text> ();
		playerScore = GameObject.Find("playerScore").GetComponent<Score> ();
		//score = GameObject.FindGameObjectWithTag ("score").GetComponent<Text> ();
		playerScore = score.GetComponent<Score> ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (textArea.text.Equals(expectedResult)) {
			Debug.Log ("It's in bounds! It's" + textArea.text);
			playerScore.addScore (10);
		//	score = playerScore.addScore (49);
		}
	}
}
