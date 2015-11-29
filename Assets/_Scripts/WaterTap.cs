using UnityEngine;
using System.Collections;

public class WaterTap : MonoBehaviour {
	private bool isRunning = false;
	private ParticleSystem sinkWater;
	public GameObject sinkWaterObj;

	void Awake(){
		sinkWater = sinkWaterObj.GetComponent<ParticleSystem> ();
	}

	void OnTriggerEnter(Collider other){
		sinkWater.Play ();
	}

	void OnTriggerExit(Collider other){
		sinkWater.Stop ();
	}

	void OnCollisionEnter(Collision other){
		sinkWater.Play ();
	}

	void OnCollisionExit(Collision other){
		sinkWater.Stop ();
	}
}
