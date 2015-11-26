using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

	private float oldHealth;
	// Use this for initialization
	void Start () {
		oldHealth = ItemCollection.health;
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (ItemCollection.health < oldHealth) {
			Debug.Log ("shake camera");
			StartCoroutine(Shake (0.1f, 2f));
		}

		oldHealth = ItemCollection.health;
*/
	}

	public static IEnumerator Shake(float duration, float magnitude) {
		Debug.Log ("shaking...");


		float elapsed = 0.0f;
		
		Vector3 originalCamPos = Camera.main.transform.position;
		
		while (elapsed < duration) {
			
			elapsed += Time.deltaTime;          
			
			float percentComplete = elapsed / duration;         
			float damper = 1.0f - Mathf.Clamp(4.0f * percentComplete - 3.0f, 0.0f, 1.0f);
			
			// map value to [-1, 1]
			float x = Random.value * 2.0f - 1.0f;
			float y = Random.value * 2.0f - 1.0f;
			x *= magnitude * damper;
			y *= magnitude * damper;
			
			Camera.main.transform.position = new Vector3(x + originalCamPos.x, y + originalCamPos.y, originalCamPos.z); 
			
			yield return null;
		}
		
		Camera.main.transform.position = originalCamPos;
	}
}
