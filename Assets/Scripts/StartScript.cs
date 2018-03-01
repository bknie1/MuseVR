using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Initial menu

	public void ChooseFromFS() {
		SceneManager.LoadScene ("FSScene");
	}

	public void ChooseNCSMusic() {
		SceneManager.LoadScene ("NCSScene");
	}

	public void Quit() {
		Application.Quit ();
	}
}
