using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emojiMove : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float Hspeed = 100;
		transform.Translate(Vector2.down*Hspeed*Time.deltaTime);
	}
}
