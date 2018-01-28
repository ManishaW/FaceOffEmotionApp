using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSurprise : MonoBehaviour {

	private string expectedResult = "Surprise";
	Text textArea;
	private Score playerScore; 

	// Use this for initialization
	void Start () {
		textArea = GameObject.Find ("EmotionDisplay").GetComponent<Text> ();
		GameObject playerScoreObject = GameObject.FindWithTag("score");
		playerScore = playerScoreObject.GetComponent<Score>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if (textArea.text.Equals(expectedResult)) {
			playerScore.addScore (10);
		}
	}
}

