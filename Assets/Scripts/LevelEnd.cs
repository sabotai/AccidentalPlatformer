using UnityEngine;
using System.Collections;

public class LevelEnd : MonoBehaviour {

	public static bool end;

	// Use this for initialization
	void Start () {
		end = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (end) {
			AudioSource audio = GetComponent<AudioSource>();
			if (audio.isPlaying == false)
				audio.Play();
			Camera.main.orthographicSize -= 3f * Time.deltaTime;
			Debug.Log ("winz" + Camera.main.orthographicSize);

			if (Camera.main.orthographicSize < 1f) 
				Application.LoadLevel(Application.loadedLevelName);
		}
	}
}
