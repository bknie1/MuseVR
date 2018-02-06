using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class OptionsScript : MonoBehaviour {

	// Main options menu

	private string color;
	public GameObject prefab;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
		color = "Red";
	}

	public string getColor(){
		return color;
	}

	public void setColor(string c){
		color = c;
	}

	public GameObject getPrefab (){
		return prefab;
	}

	public void setPrefab(GameObject p){
		prefab = p;
	}

	public void colorScene(){
		SceneManager.LoadScene ("ColorScene");
	}

	public void visScene(){
		SceneManager.LoadScene ("ChooseVisScene");
	}

	public void Randomize(){
		switch (Random.Range (0, 12)) {
			case 0:	{color = "White"; break;}
			case 1:	{color = "Red"; break;}
			case 2:	{color = "Green"; break;}
			case 3:	{color = "Blue"; break;}
			case 4:	{color = "Yellow"; break;}
			case 5:	{color = "Cyan"; break;}
			case 6:	{color = "Hot Pink"; break;}
			case 7:	{color = "Orange"; break;}
			case 8:	{color = "Pink"; break;}
			case 9:	{color = "Lime Green"; break;}
			case 10:{color = "Light Green"; break;}
			case 11:{color = "Purple"; break;}
			case 12:{color = "Light Blue"; break;}
		}
	}

	public void Back(){
		SceneManager.LoadScene ("StartScene");
	}

	public void Continue(){
		SceneManager.LoadScene ("VisualizerScene");
	}
}
