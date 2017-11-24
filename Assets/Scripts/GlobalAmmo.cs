using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour {
	public static int currentAmmo;
	public static int loadedAmmo;
	public int internalLoaded;
	public int internalAmmo;
	public GameObject AmmoDisplay;
	public GameObject LoadedDisplay;
	// Use this for initialization
	void Start () {
		currentAmmo = 40;
	}
	
	// Update is called once per frame
	void Update () {
		internalAmmo = currentAmmo;
		internalLoaded = loadedAmmo;
		AmmoDisplay.GetComponent<Text> ().text = currentAmmo + "";
		LoadedDisplay.GetComponent<Text> ().text = "" + loadedAmmo;
	}
}
