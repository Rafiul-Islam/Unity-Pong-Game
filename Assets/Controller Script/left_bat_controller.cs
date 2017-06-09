﻿using UnityEngine;
using System.Collections;

public class left_bat_controller : MonoBehaviour {

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = this.GetComponent <Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {	
			
			rb.velocity = new Vector2 (0f, 10f);	

		} else if (Input.GetKey (KeyCode.S)) {
			
			rb.velocity = new Vector2 (0f, -10f);

		} else {
			
			rb.velocity = new Vector2 (0f, 0f);

		}
	
	}
}
