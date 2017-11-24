//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class AmmoPickup : MonoBehaviour {
//	public AudioSource ammoSound;
//	// Use this for initialization
//	void Start () {
//		
//	}
//
//	void OnTriggerEnter(Collider other)//might need to add a if statement for compare tags, dont want bullets to be able to pickup more ammo for the player
//	{
//		ammoSound.Play ();
//		if (GlobalAmmo.loadedAmmo == 0) {
//			GlobalAmmo.loadedAmmo += 10;
//			this.gameObject.SetActive (false);
//		} else {
//			GlobalAmmo.currentAmmo += 10;
//			this.gameObject.SetActive (false);
//		}
//	}
//
//
//	//maybe add a coroutine/ienumerator to reset the setActive after a certain amount of time 
//
//
//	// Update is called once per frame
//	void Update () {
//
//	}
//}
