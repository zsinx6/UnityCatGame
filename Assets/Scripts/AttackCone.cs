using UnityEngine;
using System.Collections;

public class AttackCone : MonoBehaviour {

	public Turret turretAI;
	public bool isLeft = false;

	void Awake(){
		turretAI = gameObject.GetComponentInParent<Turret> ();
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			if (isLeft) {
				turretAI.Attack (false);
			} else {
				turretAI.Attack (true);
			}
		}
	}
}
