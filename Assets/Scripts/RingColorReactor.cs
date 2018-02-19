using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingColorReactor : MonoBehaviour {

	// TODO: Lights are not reacting on all instances of the object, and are still too flashy

	private static GameObject OptionsManager;
	private static float prevSpecCol = 0; // Initialized for Lerp
	private static float reduction = 2f; // Decrease to increase glow brightness (1-10, 2 default)
	private static float changespeed = 4; // Speed of Lerp (2-64, 4 default)
	private static float lightmult = 4f; // Light intensity (1-3, 4 default)
	private static float specCol = 0f; // Interpolated color;
	private static float rgbmod = .255f; // Maximum color value. .255f
	private static float rgbhalfmod = .128f;
	private Color newColor; // Colors to set each frame
	private Color newColor2;
	private float red = 0f; // Amount of each color. 0 - .255f. Only initialized here.
	private float green = 0f;
	private float blue = 0f;
	private float alpha = 1f; // (1)

	void Start () 
	{
		OptionsManager = GameObject.Find ("OptionsManager");
	}

	void Update () 
	{
		specCol = Mathf.Lerp(prevSpecCol, this.gameObject.transform.lossyScale.y / reduction, Time.deltaTime * changespeed); // This needs SIGNIFICANT fine tuning.
		prevSpecCol = specCol;
		colorPicker ();
		newColor = new Color (red, green, blue, alpha);
		newColor2 = new Color (red / rgbmod, green / rgbmod, blue / rgbmod, alpha);
		this.gameObject.GetComponent<Renderer> ().material.SetColor ("_Color", newColor);
		this.gameObject.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", newColor2);
		this.gameObject.GetComponent<Light> ().color = newColor;
		this.gameObject.GetComponent<Light> ().intensity = specCol * lightmult;
	}

	void colorPicker()
	{ // There has to be a more efficient way to do this.
		switch (OptionsManager.GetComponent<OptionsScript>().getColor())
		{
		case "White":{
				green = specCol * rgbmod;
				red = specCol * rgbmod;
				blue = specCol * rgbmod;
				break;}
		case "Red":{
				red = specCol * rgbmod;
				break;}
		case "Green":{
				green = specCol * rgbmod;
				break;}
		case "Blue":{
				blue = specCol * rgbmod;
				break;}
		case "Yellow":{
				red = specCol * rgbmod;
				green = specCol * rgbmod;
				break;}
		case "Cyan":{
				green = specCol * rgbmod;
				blue = specCol * rgbmod;
				break;}
		case "Hot Pink":{
				blue = specCol * rgbmod;
				red = specCol * rgbmod;
				break;}
		case "Orange":{
				red = specCol * rgbmod;
				green = specCol * rgbhalfmod;
				break;}
		case "Pink":{
				red = specCol * rgbmod;
				blue = specCol * rgbhalfmod;
				break;}
		case "Lime Green":{
				green = specCol * rgbmod;
				red = specCol * rgbhalfmod;
				break;}
		case "Light Green":{
				green = specCol * rgbmod;
				blue = specCol * rgbhalfmod;
				break;}
		case "Purple":{
				blue = specCol * rgbmod;
				red = specCol * rgbhalfmod;
				break;}
		case "Light Blue":{
				blue = specCol * rgbmod;
				green = specCol * rgbhalfmod;
				break;}
		}
	}
}
