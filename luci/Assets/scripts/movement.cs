using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float speed;
	private float moveInput;
	private float moveInput2;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		moveInput = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(moveInput * speed,rb.velocity.y);
		moveInput2 = Input.GetAxis("Vertical");
		rb.velocity = new Vector2(rb.velocity.x, moveInput2 * speed);
	}
}
