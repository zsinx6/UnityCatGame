using UnityEngine;
using System.Collections;

public class GO : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Destroy (GameObject.FindGameObjectWithTag ("Persistent"));

			Application.LoadLevel (0);
		}
	}
}
