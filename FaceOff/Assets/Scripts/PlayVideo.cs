using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour {
	
	public MovieTexture movie;


	// Use this for initialization
	void Start () {
		GetComponent<RawImage>().texture = movie as MovieTexture;
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();		
		movie.loop = true;
		movie.Play ();

	}

	void Update () {
		

	}
}