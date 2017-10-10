using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour 
{
	public Vector2 speed;

	Rigidbody2D rb;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = speed;
	}
	
	// Update is called once per frame
	void Update () 
	{
		rb.velocity = speed;
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag ("ENEMY")) {
			Destroy (other.gameObject);
			Destroy (gameObject);

		}
	}
}
