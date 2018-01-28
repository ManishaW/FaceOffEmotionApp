using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Score : NetworkBehaviour {


	//[SyncVar(hook = "addScore")]
	public int score = 0;

	Text score1;
	Text score2;


	// Use this for initialization
	void Start () {
		score1 = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		score1.text = "Score: " + score;
	}

	public void addScore(int s){
		score =+ s;
	//	score1.text = "Score: " + score;

		CmdScoreUp (score);
	}

	[Command]
	public void CmdScoreUp(int s){
		RpcScoreUp (s);
	}

	[ClientRpc]
	public void RpcScoreUp(int s){

		if (!isLocalPlayer) {
			score = s;
			score2.text = s.ToString ();
		}
	}

}
