using UnityEngine;
using System.Collections;

public class AroundGround : MonoBehaviour {


	public Transform[] path;

	// Use this for initialization
	void Start () {
		StartCoroutine (Go ());
	}

	IEnumerator Go(){
		while (true) {
			yield return new WaitForSeconds (0.1f);
			iTween.MoveTo (gameObject, iTween.Hash("path", path, "time", 1, "easetype", iTween.EaseType.linear));
		}	
	}

	// Update is called once per frame
	void Update () {

	}
}
