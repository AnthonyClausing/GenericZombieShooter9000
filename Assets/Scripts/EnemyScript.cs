using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	Transform player;
	UnityEngine.AI.NavMeshAgent nav;
	GlobalHealth playerHealth;
	EnemyHealth enemyHealth;

	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerHealth = player.GetComponent <GlobalHealth> ();
		enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
	}
		
	void Update ()
	{
		if(enemyHealth.currentHealth > 0 && playerHealth.playerHealth > 0)
		{
			nav.SetDestination (player.position);
		}
		else
		{
			nav.enabled = false;
		}
		}
}
