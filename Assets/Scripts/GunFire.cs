using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {

	AudioSource gunAudio;
	Animation gunAnim;
	public GameObject Flash;
	//public GameObject Bullet;
	//public Transform bulletSpawn;
	//public int bulletSpeed;

	void Start () {
		gunAudio = GetComponent<AudioSource> ();
		gunAnim = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
			{
				gunAudio.Play ();
				gunAnim.Play ("GunShot");
				Flash.SetActive (true);
				//CmdFire ();
				StartCoroutine (MuzzleOff());
			}

	}
//	public void CmdFire(){
//		var bullet = Instantiate (Bullet, bulletSpawn.position, bulletSpawn.rotation) as GameObject;
//
//		BulletController b = Bullet.GetComponent<BulletController>();
//		b.playerFrom = this.gameObject;
//		bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.up * bulletSpeed;
//
//		Destroy (bullet, 2.0f);
//	}
	IEnumerator MuzzleOff()
	{
		yield return new WaitForSeconds (0.3f);
		Flash.SetActive (false);
	}
}
