using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpectrumReactor : MonoBehaviour {

	public GameObject prefab;
	private GameObject[] prefabList;
	private AudioSource aS;
	private int prefabCount = 32; // Number of visualizer cubes
	private float radius = 10f; // Radius of the visualizer circle
	private float height = 0f; // Height of the visualizer circle
	private float lerpMod = 32; // Delay of the visualizer cube reaction
	private int samples = 1024; // Number of samples to utilize

	void Start () {
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
		AudioClip aC = GameObject.Find ("EventManager").GetComponent<EventManager> ().getClip(); // If this is null, restart application
		aS.clip = aC;
		aS.clip.name = "userMusic";
		aS.Play ();
	}

	void Update () {
		float[] spectrum = new float[samples]; // Test this further.
		AudioListener.GetSpectrumData (spectrum, 0, FFTWindow.Rectangular); // This increases or decreases the sensitivity of the bars, at the cost of some performance. Some may prefer the lower settings.
		for (int i = 0; i < prefabCount; i++) {
			Vector3 prefabScale = prefabList [i].transform.localScale;
			prefabScale.y = Mathf.Lerp (prefabScale.y, spectrum [i] * lerpMod, Time.deltaTime * lerpMod);
			prefabList[i].transform.localScale = prefabScale;
		}
		if (!aS.isPlaying) {
			// Load loading scene
		}
	}
}
