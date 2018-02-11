using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmojiFall : MonoBehaviour {
	int[] emojiPosition = { -20, 80, 180, 280 };
	public GameObject emojiOriginal; 
	public GameObject emojiInstance; 
	public Sprite [] emojiSprite;
	private int position_index = 0;
	Text timesUpAnim;
	Text perfectAnim;
	Text textArea;

	public GameObject placeholder;
	private Rigidbody2D expressionEmoji;
	public Text score;
	private Score playerScore;

	// Use this for initialization
	void Start () {
		textArea = GameObject.Find ("EmotionDisplay").GetComponent<Text> ();

		perfectAnim= GameObject.Find ("textPerfect").GetComponent<Text> ();
		perfectAnim.enabled = false;

		playerScore = GameObject.FindGameObjectWithTag ("score").GetComponent<Score> ();
		expressionEmoji = placeholder.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if (textArea.text.Equals(expectedResult) && col.gameObject.tag.Equals("moji")){
			Debug.Log ("It's in bounds! It's" + textArea.text);
			perfectAnim.enabled = true;
			perfectAnim.GetComponent<Animation> ().Play();

			playerScore.addScore (10);
		}
	}
}
