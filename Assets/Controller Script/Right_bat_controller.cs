using UnityEngine;
using System.Collections;

public class Right_bat_controller : MonoBehaviour {

	private Rigidbody2D rb2;

	// Use this for initialization
	void Start () {

		rb2 = this.GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {

			rb2.velocity = new Vector2 (0f, 10f);

		} else if (Input.GetKey (KeyCode.DownArrow)) {

			rb2.velocity = new Vector2 (0f, -10f);

		} else {

			rb2.velocity = new Vector2 (0f, 0f);

		}
	
	}
}
