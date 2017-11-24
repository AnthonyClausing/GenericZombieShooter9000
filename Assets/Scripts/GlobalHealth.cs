using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour {
	public int playerHealth = 100;
	public int internalHealth;
	public GameObject HealthDisplay;
	bool isDead;
	bool damaged;

	void Awake(){
		internalHealth = playerHealth;
	}
	// Update is called once per frame
	void Update () {
		internalHealth = playerHealth;
		HealthDisplay.GetComponent<Text> ().text = "Health: " + playerHealth;
		if (damaged) {
			playerHealth -= 10;
		}
		damaged = false; 
	}
	public void TakeDamage (int amount)
	{
		damaged = true; 

		playerHealth -= amount;

	
		if(playerHealth <= 0 && !isDead)
		{
			Death ();
		}
	}


	void Death ()
	{
		isDead = true;
		SceneManager.LoadScene ("Game Over");
	}
}
