using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
	public int startingHealth = 15;//starting health
	public int currentHealth;//current health
	public int scoreValue = 10;
	bool isDead;
	CapsuleCollider capsuleCollider;

	// Use this for initialization
	void Awake () {
		capsuleCollider = GetComponent <CapsuleCollider> ();
		currentHealth = startingHealth;
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	public void DeductPoints (int amount)// public function means it CAN BE called from another script, using the Vector3 to know where the particles(fluff) should come out from.
	{
		if(isDead) //if the enemy is dead do nothing leave this function
			return;

		currentHealth-= amount; // make their health less from the dmg taken


		if(currentHealth <= 0)//if no more health call death function
		{
			Death ();
		}
	}
	void Death ()
	{
		isDead = true; //set 
		Destroy( this.gameObject);
		ScoreManager.score += 10;
		// because you dont physically hit triggers if the enemy is dead they arent an obstacle anymore
	}
}
