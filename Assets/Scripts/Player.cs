using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 50f;
	public float jumpPower = 150f;
	public float maxSpeed = 3;


	public bool canDoubleJump;
	public bool grounded;

	public bool doubleJumpAdd;

	//Stats
	public int curHealth;
	public int maxHealth = 2;



	private Rigidbody2D rb2d;
	private Animator anim;
	private gameMaster gm;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator>();

		curHealth = maxHealth;
		doubleJumpAdd = true;
		gm = GameObject.FindGameObjectWithTag ("GameMaster").GetComponent<gameMaster> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("Grounded", grounded);
		anim.SetFloat ("Speed", Mathf.Abs(rb2d.velocity.x));
		if (Input.GetAxis ("Horizontal") < -0.1f) {
			transform.localScale = new Vector3 (-0.5f, 0.5f, 1f);
		}
		if (Input.GetAxis ("Horizontal") > 0.1f) {
			transform.localScale = new Vector3 (0.5f, 0.5f, 1f);
		}

		if(Input.GetButtonDown("Jump")){
			if (grounded) {
				rb2d.AddForce (Vector2.up * jumpPower);
				canDoubleJump = true;
			} else {
				if (canDoubleJump && doubleJumpAdd) {
					canDoubleJump = false;
					rb2d.velocity = new Vector2(rb2d.velocity.x, 0f);
					rb2d.AddForce(Vector2.up * jumpPower);
				}
			}
		}

		if (curHealth > maxHealth) {
			curHealth = maxHealth;
		}

		if (curHealth <= 0) {
			Die ();
		}
	}

	void FixedUpdate(){

		//friction
		Vector3 easeVelocity = rb2d.velocity;
		easeVelocity.y = rb2d.velocity.y;
		easeVelocity.z = 0.0f;
		easeVelocity.x *= 0.75f;

		float h = Input.GetAxis ("Horizontal");

		//apply friction
		if (grounded) {
			rb2d.velocity = easeVelocity;
		}

		//moving
		rb2d.AddForce((Vector2.right * speed) * h);

		//limit maxspeed
		if (rb2d.velocity.x > maxSpeed) {
			rb2d.velocity = new Vector2 (maxSpeed, rb2d.velocity.y); 
		}
		if (rb2d.velocity.x < -maxSpeed) {
			rb2d.velocity = new Vector2 (-maxSpeed, rb2d.velocity.y); 
		}
	}

	void Die(){

		//restart
		Application.LoadLevel (Application.loadedLevel);
	}

	public void Damage(int dmg){
		curHealth -= dmg;
		gameObject.GetComponent<Animation> ().Play ("Cat_Dmg");
	}

	public IEnumerator Knockback(float knockDur, float knockbackPwr, Vector3 knockbackDir){
		float timer = 0;
		rb2d.velocity = new Vector2 (rb2d.velocity.x, 0);
		while (knockDur > timer) {
			timer += Time.deltaTime;
			rb2d.AddForce(new Vector3(knockbackDir.x * -100, knockbackDir.y * knockbackPwr, transform.position.z));
		}
		yield return 0;
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Coin")) {
			Destroy (col.gameObject);
			gm.points += 1;
		}
	}

	public void setDJ(){
		doubleJumpAdd = true;
	}
}
