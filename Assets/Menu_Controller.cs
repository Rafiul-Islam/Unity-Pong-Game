using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour {

	public Button play_button;
	public Button quit_button;

	public void play_game(){
	
		SceneManager.LoadScene (1);
	}

	public void quit_game(){
	
		Application.Quit ();

	}
}
