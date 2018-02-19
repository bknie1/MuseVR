using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VisScript : MonoBehaviour {

	public GameObject Cube;
	public GameObject Cylinder;
	public GameObject Sphere;
	public GameObject Capsule;
	private static GameObject OptionsManager;
	private static GameObject VisText;

	void Start () 
	{
		OptionsManager = GameObject.Find ("OptionsManager");
		VisText = GameObject.Find ("VisText");
	}

	public void setCube()
	{
		OptionsManager.GetComponent<OptionsScript> ().setPrefab (Cube);
		VisText.GetComponent<UnityEngine.UI.Text> ().text = "Cube";
	}

	public void setCylinder()
	{
		OptionsManager.GetComponent<OptionsScript> ().setPrefab (Cylinder);
		VisText.GetComponent<UnityEngine.UI.Text> ().text = "Cylinder";
	}

	public void setSphere()
	{
		OptionsManager.GetComponent<OptionsScript> ().setPrefab (Sphere);
		VisText.GetComponent<UnityEngine.UI.Text> ().text = "Arc";
	}
	public void setCapsule()
	{
		OptionsManager.GetComponent<OptionsScript> ().setPrefab (Capsule);
		VisText.GetComponent<UnityEngine.UI.Text> ().text = "Capsule";
	}

	public void Back()
	{
		SceneManager.LoadScene ("OptionsScene");
	}
}
