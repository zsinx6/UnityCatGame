using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {


	public Text pointsText;
	public Text InputText;

	private Animator anim;
	public bool key;
	private Persistent ps;

	// Use this for initialization
	void Start () {
		key = false;
		anim = GameObject.FindGameObjectWithTag ("Finish").GetComponent<Animator> ();
		ps = GameObject.FindGameObjectWithTag ("Persistent").GetComponent<Persistent> ();
	}
	
	// Update is called once per frame
	void Update () {
		pointsText.text = ("Points: " + ps.coins);
	}

	public void Key(){
		anim.Play ("portal_open");
		key = true;
	}
}
