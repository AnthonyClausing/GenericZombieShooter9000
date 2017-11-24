using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
	public float timeBetweenAttacks = 0.5f; // time between attacks so they cant auto-kill you the second youre in range
	public int attackDamage = 10; // how much the attack does

	GameObject player;
	GlobalHealth playerHealth; // Reference to the PlayerHealth script
	EnemyHealth enemyHealth; 
	bool playerInRange; //true/false to check if player is in Range to being attack
	float timer; // make sure things are happening in sync (enemies arent attack too fast or too slow




	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");// gets the player and stores the object locally in the Awake function for use later so references arent always neded.
		playerHealth = player.GetComponent <GlobalHealth> ();
		enemyHealth = GetComponent<EnemyHealth>();
	}


	void OnTriggerEnter (Collider other)// Gets called whenever something goes INTO a trigger since triggers DO NOT inherently do anything. If Im the enemy and something collides chances are OTHER is the player
	{//other above is whatever collided with THIS collider 
		if(other.gameObject == player)// This is to make sure the (other) collider/gameObject is the player which was a value captured in the Awake method
		{
			playerInRange = true;
		}
	}


	void OnTriggerExit (Collider other)// if the player isnt on the trigger anymore player is no longer in range
	{
		if(other.gameObject == player)
		{
			playerInRange = false;
		}
	}


	void Update ()
	{
		timer += Time.deltaTime;

		if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth> 0)
		{
			Attack ();
		}
	}


	void Attack ()
	{
		timer = 0f;

		if(playerHealth.playerHealth > 0)
		{
			playerHealth.TakeDamage (attackDamage);
		}
	}
}


