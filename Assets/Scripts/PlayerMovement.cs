using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	Rigidbody2D rbody;
	Animator anim;
	public float Speed = 0.1f;


	private bool attacking;
	public float AttackTime;
	private float attackTimeCounter;
	public int damage = 3;

	public float MeleeRange;

	public bool CanMove;


	private Collider2D objectToBeHit;
	private bool toBeHitExists;
	// Use this for initialization
	void Awake () {
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		anim.SetBool ("IsAttacking", false);
		CanMove = true;
		toBeHitExists = false;
	}

	// Update is called once per frame
	void Update () {
		if (CanMove == false) {
		
			rbody.velocity = Vector2.zero;
			return;
		}



			Vector2 movementVector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

			if (movementVector != Vector2.zero) {
				anim.SetBool ("IsWalking", true);
				anim.SetFloat ("InputX", movementVector.x);
				anim.SetFloat ("InputY", movementVector.y);

			} else {
				anim.SetBool ("IsWalking", false);
			}

		rbody.MovePosition (rbody.position + movementVector * GameInfo.Agility* Speed * Time.fixedDeltaTime);



		if(attacking == false){
			if (Input.GetKeyUp (KeyCode.E)) {
				attacking = true;
			attackTimeCounter = AttackTime;
			rbody.velocity = Vector2.zero;
			anim.SetBool ("IsAttacking", true);


				Collider2D[] hitObjects = Physics2D.OverlapCircleAll (transform.position, MeleeRange);

			for (int i = 0; i < hitObjects.Length; i++) {

				if (hitObjects [i].tag == "Enemy") {
				
					objectToBeHit = hitObjects [i];
					toBeHitExists = true;
					Debug.Log ("ToBeHitExists");
					//objectToBeHit.gameObject.GetComponent<BossHealth> ().HurtEnemy (damage * GameInfo.Strength);
					objectToBeHit.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (damage * GameInfo.Strength);
					Debug.Log (hitObjects.Length);
					attackTimeCounter = AttackTime;
					rbody.velocity = Vector2.zero;
					anim.SetBool ("IsAttacking", true);

				} else if (hitObjects [i].tag == "Boss") {
					objectToBeHit = hitObjects [i];
					toBeHitExists = true;
					Debug.Log ("ToBeHitExists");
					objectToBeHit.gameObject.GetComponent<BossHealth> ().HurtEnemy (damage * GameInfo.Strength);
					//objectToBeHit.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (damage * GameInfo.Strength);
					Debug.Log (hitObjects.Length);
					attackTimeCounter = AttackTime;
					rbody.velocity = Vector2.zero;
					anim.SetBool ("IsAttacking", true);
				
				
				}else if (hitObjects [i].tag == "Villager") {
						objectToBeHit = hitObjects [i];
						toBeHitExists = true;
						Debug.Log ("ToBeHitExists");
						objectToBeHit.gameObject.GetComponent<VillagerHealth> ().HurtEnemy (damage * GameInfo.Strength);
						//objectToBeHit.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (damage * GameInfo.Strength);
						Debug.Log (hitObjects.Length);
						attackTimeCounter = AttackTime;
						rbody.velocity = Vector2.zero;
						anim.SetBool ("IsAttacking", true);


					}
					else{
					toBeHitExists = false;
				}
			}
			}


			//if (hitObjects.Length > 1) {
		

		}
		
		if (attackTimeCounter >= 0) {
		
			attackTimeCounter -= Time.deltaTime;
		}
		if (attackTimeCounter <= 0) {
		
			attacking = false;
			anim.SetBool ("IsAttacking", false);
		}
	}
}
