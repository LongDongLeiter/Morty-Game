using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MortyMover : MonoBehaviour {


	public KeyCode moveUp;
	public KeyCode moveDown;
	public GameObject Bullet;

	Transform firePos;

	Vector3 tempPos;

	void Start () {

		Vector3 tempPos = transform.position;


		firePos = transform.Find ("firePos");

	}


	void Update () {
		//player movement:
		if (Input.GetKeyUp (moveUp)) {
			tempPos = transform.position;

			tempPos.x += 0.5f;

			tempPos.y += 1.5f;

			transform.position = tempPos;
		}

		if (Input.GetKeyDown (moveDown)) {
			tempPos = transform.position;

			tempPos.x += -0.5f;

			tempPos.y -= 1.5f;

			transform.position = tempPos;
		}

		//bullet movement:
		if (Input.GetKeyDown (KeyCode.Space)) {

			Fire ();
		}

	}

	void Fire ()
	{
		Instantiate (Bullet, firePos.position, Quaternion.identity);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//Detect collision of player with enemy or enemy bullet

		if (other.gameObject.CompareTag ("ENEMY") || other.gameObject.CompareTag("ENEMY BULLET")) {

			Destroy(gameObject);
			Destroy (other.gameObject);
		}
		
	}
}
