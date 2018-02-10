using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public GameObject hazard;
	public int hazardCount;
	public Vector3 spawnValues;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	private bool spawnFlag = true;


	// Use this for initialization
	void Start () {

		StartCoroutine (SpawnWaves ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator SpawnWaves () 
	{
		yield return new WaitForSeconds (startWait);
		while(spawnFlag) 
		{
			for (var i = 0; i < hazardCount; i++) 
			{
				Vector3 SpawnPosition = new Vector3 (spawnValues.x,spawnValues.y,spawnValues.z);
				Quaternion SpawnRotation = Quaternion.identity;
				Instantiate (hazard, SpawnPosition, SpawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			spawnFlag = false;
			yield return new WaitForSeconds (waveWait);

			/* 
			if (gameOver) 
			{
				restartText.text = "Press 'R' for Restart";
				restart = true;
				break;
			}

			if (bossTime) 
			{
				boss.SetActive (true);
				break;
			}
			*/
		}

	}
}
