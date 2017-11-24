//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class BulletController : MonoBehaviour {
//
//	[HideInInspector]
//	public GameObject playerFrom;
//
//	public int bulletDamage;
//
//	void OnCollisionEnter(Collision collision)
//	{
//		var hit = collision.gameObject;
//		var health = hit.GetComponent<Health> ();
//		if (health != null) 
//		{
//			health.TakeDamage (playerFrom, bulletDamage);
//		}
//		Destroy (gameObject);
//	}
//}
