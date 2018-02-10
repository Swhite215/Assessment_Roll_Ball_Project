using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWin : MonoBehaviour {

	public GameObject winParticles;
	public GameObject winWalls;
	//public AudioClip clip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			GameManager.gameStatus = GameManager.GameState.Win;
			winParticles.SetActive (true);
			winWalls.SetActive (true);
			//AudioSource.PlayClipAtPoint (clip, other.transform.position, 1.0f);
		}
	}
}
