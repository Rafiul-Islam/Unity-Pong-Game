using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_Socore : MonoBehaviour {

	public Text ScoreBoard;

	private int left_bat_score = 0;
	private int right_bat_score = 0;

	public GameObject ball;

	public static bool canAddScore = true;

	// Use this for initialization
	void Start () {

		ball = GameObject.Find ("Ball");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (ball.transform.position.x >= 22f) {

			left_bat_score++;
		}

		if (ball.transform.position.x <= -22f) {

			right_bat_score++;
		}

		if (left_bat_score >= 10) {
		
			SceneManager.LoadScene (2);		
		}

		if (right_bat_score >= 10) {
		
			SceneManager.LoadScene (3);
		}

		ScoreBoard.text = left_bat_score.ToString () + " - " + right_bat_score.ToString ();	
	}
}
