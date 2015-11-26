using UnityEngine;
using System.Collections;

public class MoveSlowly : MonoBehaviour {

	private int direction;
	// Use this for initialization
	void Start () {
		direction = Random.Range (0, 2);
		if (direction == 0)
			direction = -1;
		Debug.Log ("moving... " + direction);
		
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.left * 0.007f * direction;
	
	}
}
