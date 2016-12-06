using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {

	public int points;

	public Text pointsText;
	public Text InputText;

	private Animator anim;
	bool key;

	// Use this for initialization
	void Start () {
		key = false;
		anim = GameObject.FindGameObjectWithTag ("Finish").GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		pointsText.text = ("Points: " + points);
	}

	public void Key(){
		anim.Play ("portal_open");
		key = true;
	}
}
