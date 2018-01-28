using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Affdex;

public class PlayerEmotions : ImageResultsListener {

	private Emotions result;
	/// <summary>
	/// Indicates image results are available.
	/// </summary>
	/// <param name="faces">The faces.</param>
	public override void onImageResults(Dictionary<int, Face> faces){
		foreach (KeyValuePair<int,Face> pair in faces) {
			int faceId = pair.Key;
			Face face = pair.Value;

			float currentJoy, currentAnger, currentSadness, currentSurprise;

			face.Emotions.TryGetValue (Emotions.Joy, out currentJoy);
			face.Emotions.TryGetValue (Emotions.Anger, out currentAnger);
			face.Emotions.TryGetValue (Emotions.Sadness, out currentSadness);
			face.Emotions.TryGetValue (Emotions.Surprise, out currentSurprise);

			Emotions[] emotions = { Emotions.Joy, Emotions.Anger, Emotions.Sadness, Emotions.Surprise };
			float[] values = { currentJoy, currentAnger, currentSadness, currentSurprise };

			int maxIndex = 0;
			for (int i = 0; i < values.Length; i++) {
				if (values [i] > values [maxIndex]) {
					maxIndex = i;
				}
			}
			this.result= emotions [maxIndex];
			Text textArea = GameObject.Find ("EmotionDisplay").GetComponent<Text> ();
			textArea.text = emotions[maxIndex].ToString();
			
		}
	}


	/// <summary>
	/// Indicates that the face detector has started tracking a new face.
	/// <para>
	/// When the face tracker detects a face for the first time method is called.
	/// The receiver should expect that tracking continues until detection has stopped.
	/// </para>
	/// </summary>
	/// <param name="timestamp">Frame timestamp when new face was first observed.</param>
	/// <param name="faceId">Face identified.</param>
	public override void onFaceFound(float timestamp, int faceId){

		Debug.Log("Face Found");
	}

	/// <summary>
	/// Indicates that the face detector has stopped tracking a face.
	/// <para>
	/// When the face tracker no longer finds a face this method is called. The receiver should expect that there is no face tracking until the detector is
	/// started.
	/// </para>
	/// </summary>
	/// <param name="timestamp">Frame timestamp when previously observed face is no longer present.</param>
	/// <param name="faceId">Face identified.</param>
	public override void onFaceLost(float timestamp, int faceId){
		Debug.Log("Face Lost");
	}
}
