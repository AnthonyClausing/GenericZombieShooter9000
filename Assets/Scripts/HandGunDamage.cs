using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour {

	public int damageAmount;
	public float targetDistance;
	public float allowedRange;
	public GameObject theBullet;
	RaycastHit Hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			RaycastHit Shot;
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Shot)) {
				targetDistance = Shot.distance;
				if (targetDistance < allowedRange) {
					Shot.transform.SendMessage ("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
					}
				}
			}
		}
	}
