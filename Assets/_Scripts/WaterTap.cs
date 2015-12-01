using UnityEngine;
using System.Collections;

public class WaterTap : MonoBehaviour {
	public ParticleSystem sinkWater;

	void Awake(){
		// sinkWater = sinkWaterObj.GetComponent<ParticleSystem> ();
		sinkWater.enableEmission = false;
	}

	void OnTriggerEnter(Collider other){
		sinkWater.enableEmission = true;
	}

	void OnTriggerExit(Collider other){
		sinkWater.enableEmission = false;
	}

	void OnCollisionEnter(Collision other){
		sinkWater.enableEmission = true;
	}

	void OnCollisionExit(Collision other){
		sinkWater.enableEmission = false;
	}
}
