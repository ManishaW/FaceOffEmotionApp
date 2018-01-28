using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Score : NetworkBehaviour {


	[SyncVar(hook = "addScore")]
	public int score = 0;

	Text txt;

	// Use this for initialization
	void Start () {
		txt = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Score: " + score;
	}

	public void addScore(int s){
		score =+ s;
	}
}
