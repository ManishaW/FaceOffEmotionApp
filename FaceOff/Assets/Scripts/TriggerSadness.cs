using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSadness : MonoBehaviour {

	private string expectedResult = "Sadness";
	Text textArea;
	Text perfectAnim;

	public GameObject placeholder;
	private Rigidbody2D expressionEmoji;
	public Text score;
	private Score playerScore;

	// Use this for initialization
	void Start () {
		textArea = GameObject.Find ("EmotionDisplay").GetComponent<Text> ();

		GameObject playerScoreObject = GameObject.FindWithTag("score");
		playerScore = playerScoreObject.GetComponent<Score>();

		perfectAnim= GameObject.Find ("textPerfect").GetComponent<Text> ();
		perfectAnim.enabled = false;

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if (textArea.text.Equals(expectedResult)) {
			perfectAnim.enabled = true;
			perfectAnim.GetComponent<Animation> ().Play();

			playerScore.addScore (10);
		}
	}
}
