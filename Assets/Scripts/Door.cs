using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Door : MonoBehaviour {


	public int levelToLoad;
	private gameMaster gm;

	void Start(){
		gm = GameObject.FindGameObjectWithTag ("GameMaster").GetComponent<gameMaster> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			gm.InputText.text = ("E to enter");
			if (Input.GetKeyDown ("e")) {
				Application.LoadLevel (Application.loadedLevel+1);
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			if (Input.GetKeyDown ("e")) {
				Application.LoadLevel (Application.loadedLevel+1);
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			gm.InputText.text = (" ");
		}
	}
}
