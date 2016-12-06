using UnityEngine;
using System.Collections;

public class Persistent : MonoBehaviour {

	public int lifes;

	// Use this for initialization
	void Start () {
		lifes = 3;
	}

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
