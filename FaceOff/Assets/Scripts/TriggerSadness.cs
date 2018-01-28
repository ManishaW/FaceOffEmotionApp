using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSadness : MonoBehaviour {

	private string expectedResult = "Sadness";
	Text textArea;

	// Use this for initialization
	void Start () {
		textArea = GameObject.Find ("EmotionDisplay").GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if (textArea.text.Equals(expectedResult)) {
			Debug.Log ("It's in bounds! It's" + textArea.text);
		}
	}
}
