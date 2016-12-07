using UnityEngine;
using System.Collections;

public class WinHd : MonoBehaviour {

	private gameMaster gm;
	private Persistent ps;

	void Start(){
		gm = GameObject.FindGameObjectWithTag ("GameMaster").GetComponent<gameMaster> ();
		ps = GameObject.FindGameObjectWithTag ("Persistent").GetComponent<Persistent> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			gm.InputText.text = ("E to get\tR to shoot");
			if (Input.GetKeyDown ("e")) {
				ps.giveHado ();
				Destroy (gameObject);
				gm.InputText.text = (" ");
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			if (Input.GetKeyDown ("e")) {
				ps.giveHado ();
				Destroy (gameObject);
				gm.InputText.text = (" ");
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			gm.InputText.text = (" ");
		}
	}
}
