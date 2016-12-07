using UnityEngine;
using System.Collections;

public class GO : MonoBehaviour {


	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Destroy (GameObject.FindGameObjectWithTag ("Persistent"));
			Application.LoadLevel (1);
		}
	}
}
