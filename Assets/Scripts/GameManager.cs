using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public enum GameState { Playing, Dead, Menu, Win};
	public GameObject deathCanvas;
	public GameObject winCanvas;

	public static int level = 1;
	public static GameState gameStatus;
	// Use this for initialization
	void Start () {
		gameStatus = GameState.Playing;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameStatus == GameState.Dead) {
			deathCanvas.SetActive (true);
		} else if (gameStatus == GameState.Win) {
			winCanvas.SetActive (true);
			//Time.timeScale = 0;
		}
	}

	public void LoadLevel() {
		level++;
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		//Time.timeScale = 1;
	}
}
