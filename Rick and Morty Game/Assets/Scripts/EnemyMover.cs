using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour {


	public float speed = 1.0f;
	public GameObject EnemyBullet;
	Transform firePos2;
	public GameObject ExplosionGO;

	// Use this for initialization
	void Start () {

		firePos2 = transform.Find ("firePos2");

	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (-speed, 0, 0);


		if (Input.GetKeyDown (KeyCode.Space)) {

			Fire ();
		}
	}

	void Fire ()
	{
		Instantiate (EnemyBullet, firePos2.position, Quaternion.identity);
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag ("MORTY BULLET")) {

			PlayExplosion ();

		}
	}

	void PlayExplosion()
	{
		GameObject explosion = (GameObject)Instantiate (ExplosionGO);

		explosion.transform.position = transform.position;
	}
}
