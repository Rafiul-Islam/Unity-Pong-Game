using UnityEngine;
using System.Collections;

public class Ball_controller : MonoBehaviour {

	private Rigidbody2D rb;

	public GameObject bat1;
	public GameObject bat2;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

		bat1 = GameObject.Find("Left_Bat");
		bat2 = GameObject.Find ("Right_Bat");

		Count_Socore.canAddScore = true;
		StartCoroutine (pause ());
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Mathf.Abs(this.transform.position.x) >= 22f) {
			
		
			Count_Socore.canAddScore = true;

			this.transform.position = new Vector3 (0f, 0f, 0f);
			StartCoroutine (pause ());
		
		}
	}

	IEnumerator pause(){

		int directionX = Random.Range (-2, -3);
		int directionY = Random.Range (-2, -3);

		if (directionX == 0) {
		
			directionX = 1;

		}
		
		rb.velocity = new Vector2 (0f, 0f);
		yield return new WaitForSeconds (2);
		rb.velocity = new Vector2 (7f * directionX, 7f * directionY);
	
	}

	void onCollisionEnter2D(Collision2D hit){
	
		if (hit.gameObject.name == "bat1") {
		
			if (bat1.GetComponent<Rigidbody2D> ().velocity.y > 0.5f) {

				rb.velocity = new Vector2 (7f, 7f);
			
			} else if (bat1.GetComponent<Rigidbody2D> ().velocity.y < -0.5f) {

				rb.velocity = new Vector2 (7f, -7f);
			
			} else {

				rb.velocity = new Vector2 (7f , 0f);			
			
			}
		
		}

		if (hit.gameObject.name == "bat2") {

			if (bat2.GetComponent<Rigidbody2D> ().velocity.y > 0.5f) {

				rb.velocity = new Vector2 (-7f, 7f);

			} else if (bat2.GetComponent<Rigidbody2D> ().velocity.y < -0.5f) {

				rb.velocity = new Vector2 (-7f, -7f);

			} else {

				rb.velocity = new Vector2 (-7f , 0f);			

			}


		}
	}
}
