using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

	public int curHealth;
	public int maxHealth;

	public float distance;
	public float wakeRange;

	public float shootInterval;
	public float bulletSpeed = 100;
	public float bulletTime;

	public bool awake = false;
	public bool lookingRight = true;

	public GameObject bullet;
	public Transform target;
	public Animator anim;
	public Transform shootPointLeft, shootPointRight;


	void Awake(){
		anim = gameObject.GetComponent<Animator> ();
	}


	// Use this for initialization
	void Start () {
		curHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("Awake", awake);
		anim.SetBool ("LookingRight", lookingRight);
		RangeCheck ();

		if (target.transform.position.x > transform.position.x) {
			lookingRight = true;
		}
		if (target.transform.position.x <= transform.position.x) {
			lookingRight = false;
		}

	}

	void RangeCheck(){
		distance = Vector3.Distance (transform.position, target.position);

		if (distance <= wakeRange) {
			awake = true;
		}
		if (distance > wakeRange) {
			awake = false;
		}
	}

	public void Attack(bool attackingRight){
		bulletTime += Time.deltaTime;
		if (bulletTime >= shootInterval) {
			Vector2 direction = target.transform.position - transform.position;
			direction.Normalize ();

			if (!attackingRight) {
				GameObject bulletClone;
				bulletClone = Instantiate (bullet, shootPointLeft.transform.position, shootPointLeft.transform.rotation) as GameObject;

				bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

				bulletTime = 0;
			}
			if (attackingRight) {
				GameObject bulletClone;
				bulletClone = Instantiate (bullet, shootPointRight.transform.position, shootPointRight.transform.rotation) as GameObject;

				bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

				bulletTime = 0;
			}
		} 
	}
}
