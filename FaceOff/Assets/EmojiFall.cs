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



	// Use this for initialization
	void Start () {
		//float randTime = Random.Range (1, 3);
<<<<<<< HEAD
		InvokeRepeating ("createEmoji", 5, Random.Range(1, 3));
=======
		AudioListener.pause = false;
		StartCoroutine ("Countdown", 30);
		InvokeRepeating ("createEmoji", 5, Random.Range(1, 3));
		timesUpAnim= GameObject.Find ("timesUp").GetComponent<Text> ();
		timesUpAnim.enabled = false;
>>>>>>> ec391d8613e75e62b2db935119ff286e4f81f832
	
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime);
	}

	private IEnumerator Countdown(int time){
		while (time > 0) {
			Debug.Log (time--);
			yield return new WaitForSeconds (1);
		}
		if (time == 0) {
			CancelInvoke ();
			perfectAnim= GameObject.Find ("textPerfect").GetComponent<Text> ();
			perfectAnim.enabled = false;
			timesUpAnim.enabled = true;
			timesUpAnim.GetComponent<Animation> ().Play();
			AudioListener.pause = true;
			Debug.Log ("Time's up!");
		}
	}

	void createEmoji(){
		int rand = Random.Range(1, 16);
		position_index = (position_index + rand) % 4;
		Vector3 position = new Vector3 (emojiPosition[position_index], 375, 0);
		emojiInstance = Instantiate (emojiOriginal, position, Quaternion.identity) as GameObject;
		emojiInstance.GetComponent<SpriteRenderer>().sprite = emojiSprite[position_index];
		


					


	}
}
