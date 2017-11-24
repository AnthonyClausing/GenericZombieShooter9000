using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunReload : MonoBehaviour {
	public AudioSource ReloadSound;
	public GameObject CrossHairs;
	public GameObject Mechanics;
	public Animation ReloadAnim;
	int clipCount;
	//int reserveCount;
	//int reloadAvailable;

	// Use this for initialization
	void Start () {
		ReloadAnim = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
		clipCount = GlobalAmmo.loadedAmmo;
		//reserveCount = GlobalAmmo.currentAmmo;

		if(Input.GetButtonDown("Reload"))
		{
			if (clipCount == 0) {
				GlobalAmmo.loadedAmmo += 10;
			}
			ActionReload ();
		} 
			StartCoroutine (EnableScripts ());	
		}

	IEnumerator EnableScripts()
	{
		yield return new WaitForSeconds (1.1f);
		this.GetComponent<GunFire> ().enabled = true;
		CrossHairs.SetActive (true);
		Mechanics.SetActive (true);
	}

	void ActionReload()
	{
		this.GetComponent<GunFire>().enabled =false;
		CrossHairs.SetActive (false);
		Mechanics.SetActive (false);
		ReloadSound.Play ();
		ReloadAnim.Play ("HandGunReload"); 
	}
}
