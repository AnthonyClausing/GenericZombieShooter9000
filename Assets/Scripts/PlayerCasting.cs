using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is for checking how far something is from the Player Character using a Raycast, gunfire does the same thing.
/// </summary>
public class PlayerCasting : MonoBehaviour {
	 static float distanceFromTarget;
	public float toTarget;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
			{
			toTarget = hit.distance;
			distanceFromTarget = toTarget;
			}
	}
}
