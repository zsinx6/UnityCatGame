using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour {

	bool up;
	public bool waitmore;

	// Use this for initialization
	void Start () {
		up = true;
		StartCoroutine (upDown ());
	}

	IEnumerator upDown(){
		if (waitmore) {
			yield return new WaitForSeconds (0.5f);
		}
		while (true) {
			yield return new WaitForSeconds (1f);
			if (up) {
				iTween.MoveAdd (gameObject, Vector3.up*2, 1f);
				up = false;
			} else {
				iTween.MoveAdd (gameObject, Vector3.down*2, 1f);
				up = true;
			}
		}	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
