using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour {
	
	public MovieTexture movie;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage>().texture = movie as MovieTexture;
		//audio = GetComponent<AudioSource>();
		//audio.clip = movie.audioClip;
		movie.loop = true;
		movie.Play ();

		//audio.Play ();
	}

	void Update () {
		

	}
}