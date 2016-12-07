using UnityEngine;
using System.Collections;

public class Persistent : MonoBehaviour {

	public int lifes;
	public bool isHado;
	public int coins;

	// Use this for initialization
	void Start () {
		coins = 0;
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
