using UnityEngine;
using System.Collections;

public class Hadouken : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Enemy")) {
			Destroy (col.gameObject);
			Destroy (gameObject);
		}
	}
}
