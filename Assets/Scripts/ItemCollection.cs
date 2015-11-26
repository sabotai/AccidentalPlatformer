using UnityEngine;
using System.Collections;

public class ItemCollection : MonoBehaviour {

	// 2 methods of doing things
	public static int score = 0; //public static method can be accessed globally, which is useful when there is ONLY 1 COPY
	public int localScore = 0;   //regular public is default viewable in the inspector and accessed with GameObject.GetComponent... etc.

	// health as a percentage
	public static float health = 1f;
	public float localHealth = 1f;

	public AudioSource hurtSnd;
	public AudioSource pickupSnd;

	void Start(){
		health = 1f;
		localHealth = 1f;

		score = 0;
		localScore = 0;
	}

	void OnCollisionEnter2D(Collision2D loCol){
		//Debug.Log ("any collision");

		switch (loCol.gameObject.tag) {
		case "item":
			//Debug.Log ("item picked up");
			localScore +=1;
			score+=1;
			Destroy(loCol.gameObject);
			pickupSnd.Play();
			break;
			
		case "exit":
			LevelEnd.end = true;
			break;

		case "enemy":
			//Debug.Log ("enemy collision // health = " + health);
			health -= 0.2f;
			localHealth -= 0.2f;
			//Destroy(loCol.gameObject);
			hurtSnd.Play();

			if (health <= 0f)
				Application.LoadLevel(Application.loadedLevelName);


			StartCoroutine(CameraShake.Shake (0.4f, 0.1f));
			break;
		}



	}
}
