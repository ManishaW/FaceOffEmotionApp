using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Score : MonoBehaviour {


	public int score;

	Text score1;


	// Use this for initialization
	void Start () {
		score = 0;
		score1 = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		score1.text = "Score: " + score;
	}

	public void addScore(int s){
		score += s;
	}

}
