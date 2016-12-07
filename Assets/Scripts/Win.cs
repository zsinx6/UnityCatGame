using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {
	
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Destroy (GameObject.FindGameObjectWithTag ("Persistent"));
			Application.LoadLevel (Application.loadedLevel+1);
		}
	}
}
