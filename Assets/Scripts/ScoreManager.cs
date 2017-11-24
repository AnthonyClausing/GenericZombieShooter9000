using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour{
	public static int score; // a static variable doesnt belong to the instance of a class it belongs to the class itself
	// for example in the Overwatch HUD the score and time remaining are probably static but the ultimate charge, health, and bullets remaining arent

	Text text;


	void Awake ()
	{
		text = GetComponent <Text> ();
		score = 0;
	}


	void Update ()
	{
		text.text = "Score: " + score;
	}
}
