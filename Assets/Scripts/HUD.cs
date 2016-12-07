using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Sprite[] HeartSprites;
	public Sprite[] LifeSprites;

	public Image HeartUI;
	public Image LifeUI;

	private Player player;
	private Persistent ps;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
		ps = GameObject.FindGameObjectWithTag ("Persistent").GetComponent<Persistent> ();

	}
	
	// Update is called once per frame
	void Update () {
		HeartUI.sprite = HeartSprites [player.curHealth];
		LifeUI.sprite = LifeSprites [ps.lifes-1];

	}
}
