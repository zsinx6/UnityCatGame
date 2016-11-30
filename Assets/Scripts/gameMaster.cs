using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {

	public int points;

	public Text pointsText;
	public Text InputText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		pointsText.text = ("Points: " + points);
	}
}
