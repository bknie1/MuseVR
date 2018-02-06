using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class NCSScript : MonoBehaviour {

	// Stores pre-loaded music

	private AudioClip music;
	public AudioClip cetus;
	public AudioClip circles;

	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}
	
	public AudioClip getClip(){
		return music;
	}

	public void SelectCetus(){
		music = cetus;
		SceneManager.LoadScene ("OptionsScene");
	}

	public void SelectCircles(){
		music = circles;
		SceneManager.LoadScene ("OptionsScene");
	}

	public void Back(){
		SceneManager.LoadScene ("StartScene");
	}
}