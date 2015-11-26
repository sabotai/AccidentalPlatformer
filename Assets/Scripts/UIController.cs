using UnityEngine;
using System.Collections;
using UnityEngine.UI; //required since guitext is now deprecated

public class UIController : MonoBehaviour {

	private string scoreString;
	private float healthVal;
	public GameObject healthObj;
	public GameObject scoreObj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		scoreString = "SCORE: " + ItemCollection.score.ToString();

		// this line does the same thing for a non-static variable
		//scoreString = "SCORE: " + GameObject.Find ("CharacterRobotBoy").GetComponent<ItemCollection>().localScore.ToString();

		scoreObj.GetComponent<Text> ().text = scoreString;

		healthVal = ItemCollection.health;
		healthObj.GetComponent<Text> ().color = Color.Lerp (Color.red, Color.green, healthVal);

	
	}


}
