using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorScript : MonoBehaviour {

	// This script sets the color of the visualizer on button press.

	private static GameObject OptionsManager;
	private static GameObject ColorText;

	void Start () {
		OptionsManager = GameObject.Find ("OptionsManager");
		ColorText = GameObject.Find ("ColorText");
	}

	public void Red(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Red");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Red";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (255f, 0f, 0f);
	}

	public void Green(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Green");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Green";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (0f, 255f, 0f);
	}

	public void Blue(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Blue");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Blue";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (0f, 0f, 255f);
	}

	public void Yellow(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Yellow");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Yellow";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (255f, 255f, 0f);
	}

	public void Cyan(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Cyan");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Cyan";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (0f, 255f, 255f);
	}

	public void HotPink(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Hot Pink");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Hot Pink";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (255f, 0f, 255f);
	}

	public void Orange(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Orange");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Orange";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (255f, 168f, 0f);
	}

	public void Pink(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Pink");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Pink";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (255f, 0f, 168f);
	}

	public void LimeGreen(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Lime Green");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Lime Green";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (168f, 255f, 0f);
	}

	public void LightGreen(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Light Green");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Light Green";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (0f, 255f, 168f);
	}

	public void Purple(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Purple");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Purple";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (168f, 0f, 255f);
	}

	public void LightBlue(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("Light Blue");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "Light Blue";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (0f, 168f, 255f);
	}

	public void White(){
		OptionsManager.GetComponent<OptionsScript> ().setColor ("White");
		ColorText.GetComponent<UnityEngine.UI.Text> ().text = "White";
		ColorText.GetComponent<UnityEngine.UI.Text> ().color = new Color (255f, 255f, 255f);
	}

	public void Back(){
		SceneManager.LoadScene ("OptionsScene");
	}
}
