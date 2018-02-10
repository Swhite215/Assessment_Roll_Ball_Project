using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class DestroyByContact : MonoBehaviour {

	public GameObject playerExplosion;
	public AudioClip explosionSound;

	void Start() {
		
	}

	void OnTriggerEnter(Collider other) {

		if (other.tag == "Player") {
			AudioSource.PlayClipAtPoint (explosionSound, other.transform.position, 1.0f);
			GameObject newExplosion = Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			Destroy (newExplosion, 1.0f);
			GameManager.gameStatus = GameManager.GameState.Dead;

			if (gameObject.tag == "Enemy") {
				Destroy (gameObject);
			}
		}


	}

}
