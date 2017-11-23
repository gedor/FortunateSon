using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton1MoverDonekleRadi : MonoBehaviour {


	Animator anima;
	private Rigidbody2D myRigidbody;
	public Transform ObjectToMove;
	public float MovementSpeed = 5.0f;
	public bool ShouldLoop = true;
	public float WaitAtWayPoint = 1.0f;
			
	public List<Transform> Waypoints = new List<Transform>();

	private int _waypointIndex = 0;
	private bool _shouldMove = true;
	private Transform _transform;
	private float _moveTimer = 0.0f;

	Vector2 movementVectorEnemy;

	public Transform target;
	public float attackRange;
	private float lastAttackTime;
	public float attackDelay;
	public int damage;

	public float AttackTime;
	private float attackTimeCounter;

	public bool ShouldMove
	{
		get { 

			return _shouldMove;
		}
		set{ 
			_shouldMove = value;
		}

	}

	void Start(){
		anima = GetComponent<Animator> ();
		myRigidbody = GetComponent<Rigidbody2D> ();
		target = GameObject.FindWithTag ("Player").transform;

	}
	void Update(){
		
		movementVectorEnemy = Waypoints[_waypointIndex].position - ObjectToMove.position;
	

		float distanceToPlayer = Vector3.Distance (transform.position, target.position);


		if (distanceToPlayer < attackRange) {
			attackTimeCounter = AttackTime;
			_shouldMove = false;
			anima.SetBool ("IsWalking", false);


			if (Time.time > lastAttackTime + attackDelay) 
			{
				if (target.gameObject.activeInHierarchy == true) {
					StartCoroutine ("AttackNow");

					lastAttackTime = Time.time;
				}


			} 


		}

		if (attackTimeCounter >= 0) {

			attackTimeCounter -= Time.deltaTime;
		}
		if (attackTimeCounter <= 0) {


			anima.SetBool ("IsAttacking", false);
		}







		if (Time.time >= _moveTimer) {
			Move ();
		}

	}
	private void Move(){

		if (Waypoints.Count != 0 && _shouldMove) {
			ObjectToMove.position = Vector3.MoveTowards (ObjectToMove.position, Waypoints [_waypointIndex].position, MovementSpeed * Time.deltaTime);
			//kada dodemo do waypointa

			anima.SetFloat ("VelocityX", movementVectorEnemy.x); 
			anima.SetFloat ("VelocityY", movementVectorEnemy.y); 

			anima.SetBool ("IsWalking", true);
			if (Vector3.Distance (ObjectToMove.position,Waypoints[_waypointIndex].position) <= 0.1f)
				{

					_waypointIndex++;
				_moveTimer = Time.time + WaitAtWayPoint;
				anima.SetBool ("IsWalking",false);
			
				}
				if (_waypointIndex >=Waypoints.Count)
				{
				if (ShouldLoop) {
					_waypointIndex = 0;
				}
					else {

					_shouldMove = false;
					anima.SetBool ("IsWalking", false);
				
				}
				}

		}



	}



	public IEnumerator AttackNow(){
	
		attackTimeCounter = AttackTime;
		anima.SetBool ("IsAttacking", true);
		anima.SetBool ("IsWalking", false);

		GameObject.FindWithTag ("Player").GetComponent<PlayerHealthManager> ().HurtPlayer (damage);
		yield return new WaitForSeconds(AttackTime);
		anima.SetBool ("IsAttacking", false);
	
	}

	}
