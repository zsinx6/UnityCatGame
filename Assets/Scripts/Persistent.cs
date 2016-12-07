using UnityEngine;
using System.Collections;

public class Persistent : MonoBehaviour {
	//this controls everything that must be persistent

	public int lifes;
	public bool isHado;
	public int coins;

	void Start () {
		coins = 0;
		lifes = 3;
		isHado = false;
	}

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}

	public void giveHado(){
		isHado = true;
	}
}
