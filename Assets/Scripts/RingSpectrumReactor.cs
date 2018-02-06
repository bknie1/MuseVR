using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RingSpectrumReactor : MonoBehaviour {

	// The variables in this class need significant fine tuning.

	private static GameObject OptionsManager; // Not yet used
	private GameObject prefab;
	private GameObject[] prefabList;
	private AudioSource aS;
	private int prefabCount = 32; // Number of visualizer cubes (32)
	private float radius = 10f; // Radius of the visualizer circle (10)
	private float height = 0f; // Height of the visualizer circle (0)
	private float lerpMod = 64; // Overall Sensitivity of the visualizer. (16-64, 64 default)
	private float timeMod = 8; // Visualizer reaction time (2-64, 8 default)
	private int samples = 1024; // Number of samples to utilize (1024)
	private AudioClip aC;

	void Start () {
		OptionsManager = GameObject.Find ("OptionsManager");
		prefab = OptionsManager.GetComponent<OptionsScript> ().getPrefab ();
		instantiatePrefabs ();
		confAudioS ();
	}

	// Instantiates the ring of prefabs (cubes) according to the count.
	void instantiatePrefabs(){
		for (int i = 0; i < prefabCount; i++) {
			float angle = i * Mathf.PI * 2 / prefabCount;
			Vector3 pos = new Vector3 (Mathf.Cos (angle), height, Mathf.Sin (angle)) * radius;
			Instantiate (prefab, pos, Quaternion.identity);
		}
		prefabList = GameObject.FindGameObjectsWithTag ("Visualize");
	}

	// Recieves audio file from the event manager, loads it, and plays it.
	void confAudioS(){
		aS = this.gameObject.GetComponent<AudioSource> ();
		if (GameObject.Find ("FSManager")) {
			aC = GameObject.Find ("FSManager").GetComponent<FSScript> ().getClip ();
		} else {
			aC = GameObject.Find ("NCSManager").GetComponent<NCSScript> ().getClip ();
		}
		aS.clip = aC;
		aS.clip.name = "userMusic";
		Invoke ("Play", 5f);
	}

	void Play(){
		aS.Play ();
		Invoke ("Reset", aS.clip.length);
	}

	void Update () { // Delay this
		float[] spectrum = new float[samples]; // Test this further.
		AudioListener.GetSpectrumData (spectrum, 0, FFTWindow.Rectangular); // This increases or decreases the sensitivity of the bars, at the cost of some performance. Some may prefer the lower settings. Essentially distributes movement to more blocks and reduces average height.
		for (int i = 0; i < prefabCount; i++) {
			Vector3 prefabScale = prefabList [i].transform.localScale;
			prefabScale.y = Mathf.Lerp (prefabScale.y, spectrum [i] * lerpMod, Time.deltaTime * timeMod);
			prefabList[i].transform.localScale = prefabScale;
		}
	}

	void Reset(){
		Destroy (GameObject.Find ("FSManager"));
		Destroy (GameObject.Find ("NCSManager"));
		SceneManager.LoadScene ("StartScene");
	}
}
