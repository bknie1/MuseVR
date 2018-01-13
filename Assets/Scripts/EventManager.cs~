using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour {

	private AudioClip music;

	// Asks the user for an mp3 (wav will also work but isn't shown), NAudio.dll turns it into a wav, and holds it for the Reactor.
	IEnumerator Start () {
		DontDestroyOnLoad (this.gameObject);

		string path = EditorUtility.OpenFilePanel ("Music File To Open", "", "mp3");
		string url = "file:///" + path;
		Debug.Log (url);
		using (WWW www = new WWW(url)){
			if (path.Length != 0) {
				yield return www;
				music = NAudioPlayer.FromMp3Data (www.bytes);
				Debug.Log (music.length);
				if (music.length != 0) {
					SceneManager.LoadScene ("RingScene");
				} 
				else {
					EditorUtility.DisplayDialog ("Error! File failed to load.", "Please select a valid mp3 file.", "Whoops!"); Application.Quit ();
				}
			} 
			else {
				EditorUtility.DisplayDialog ("Error! File failed to load.", "Please select a valid mp3 file.", "Whoops!"); Application.Quit ();
			}
		}
	}

	public AudioClip getClip(){
		return music;
	}
}
