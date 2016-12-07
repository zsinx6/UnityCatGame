using UnityEngine;
using System.Collections;

public class Persistent : MonoBehaviour {

	public int lifes;
	public bool isHado;

	// Use this for initialization
	void Start () {
		lifes = 3;
		isHado = false;
	}

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void giveHado(){
		isHado = true;
	}
}
