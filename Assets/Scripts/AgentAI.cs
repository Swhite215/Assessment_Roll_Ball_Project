using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentAI : MonoBehaviour {

	private NavMeshAgent ThisAgent = null;
	private Transform PlayerTransform = null;

	// Use this for initialization
	void Start () {
		GameObject PlayerObject = GameObject.FindGameObjectWithTag ("Player");
		PlayerTransform = PlayerObject.GetComponent<Transform> ();

		ThisAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerTransform != null) {
			ThisAgent.SetDestination (PlayerTransform.position);
		}
	}
}
