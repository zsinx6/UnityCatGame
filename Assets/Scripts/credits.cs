using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {

	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Destroy (GameObject.FindGameObjectWithTag ("Persistent"));
			Application.LoadLevel (0);
		}
	}
}
