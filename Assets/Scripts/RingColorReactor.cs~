using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingColorReactor : MonoBehaviour {

	private float prevSpecCol = 0;
	private float reduction = 5f;
	private float changespeed = 0.25f;
	private float lightmult = 2.0f;

	void Update () {
		float specCol = Mathf.Lerp(prevSpecCol, this.gameObject.transform.lossyScale.y / reduction, changespeed); // This needs SIGNIFICANT fine tuning.
		prevSpecCol = specCol;
		Color newColor = new Color (0f, 0f, specCol * .255f, 1.0f);
		Color newColor2 = new Color (0f, 0f, specCol, 1.0f);
		this.gameObject.GetComponent<Renderer> ().material.SetColor ("_Color", newColor);
		this.gameObject.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", newColor2);
		this.gameObject.GetComponent<Light> ().color = newColor;
		this.gameObject.GetComponent<Light> ().intensity = specCol * lightmult;
	}
}
