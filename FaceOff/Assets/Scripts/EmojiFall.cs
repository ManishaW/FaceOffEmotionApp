using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmojiFall : MonoBehaviour {
	string[] emojiTypes = {"joy", "sad", "surprise", "angry" };
	int[] emojiPosition = { -20, 80, 180, 280 };
	public GameObject emojiOriginal; 
	public GameObject emojiInstance; 
	public Sprite [] emojiSprite;
	private int position_index = 0;



	// Use this for initialization
	void Start () {
		//float randTime = Random.Range (1, 3);
		InvokeRepeating ("createEmoji", 5, Random.Range(2, 3));
	
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime);
		Text textArea = GameObject.Find ("EmotionDisplay").GetComponent<Text> ();

		Debug.Log ("2" + textArea.text );
	}

	void createEmoji(){
		int rand = Random.Range(1, 16);
		position_index = (position_index + rand) % 4;
		string emoji = emojiTypes [position_index];
		Vector3 position = new Vector3 (emojiPosition[position_index], 375, 0);
		emojiInstance = Instantiate (emojiOriginal, position, Quaternion.identity) as GameObject;
		emojiInstance.GetComponent<SpriteRenderer>().sprite = emojiSprite[position_index];
		


					


	}
}
