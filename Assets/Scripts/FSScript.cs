using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class FSScript : MonoBehaviour {

	private AudioClip music;

	// Asks the user for an mp3 (wav will also work but isn't shown), NAudio.dll turns it into a wav, and holds it for the visualizer.
	IEnumerator Start () {
		DontDestroyOnLoad (this.gameObject);

		string path = EditorUtility.OpenFilePanel ("Music File To Open", "", "mp3");
		string url = "file:///" + path;
		using (WWW www = new WWW(url)){
			if (path.Length != 0 && path != null) {
				yield return www;
				music = NAudioPlayer.FromMp3Data (www.bytes);
				if (music.length != 0 || music != null) {
					SceneManager.LoadScene ("OptionsScene");
				} 
				else {
					EditorUtility.DisplayDialog ("Error! File failed to load.", "Please select a valid mp3 file.", "Whoops!"); 
					SceneManager.LoadScene ("StartScene");
				}
			} 
			else {
				EditorUtility.DisplayDialog ("Error! File failed to load.", "Please select a valid mp3 file.", "Whoops!"); 
				SceneManager.LoadScene ("StartScene");
			}
		}
	}
	
	public AudioClip getClip(){
		return music;
	}
}
