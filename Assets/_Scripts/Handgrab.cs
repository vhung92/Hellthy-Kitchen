using UnityEngine;
using System.Collections;

public class Handgrab : MonoBehaviour {
	bool ObjectInArea = false;
	public KeyCode Hold;
	private GameObject rnd;
	private bool isHolding = false;

	void Update()
	{	
		if(ObjectInArea){
			if (Input.GetKeyDown (Hold)) {
				rnd.transform.parent = this.transform;
				Rigidbody rb = rnd.GetComponent<Rigidbody>();
				rb.isKinematic = true;
				isHolding = true;
			}
			if (Input.GetKeyUp(Hold)) {
				rnd.transform.parent = null;
				Rigidbody rb = rnd.GetComponent<Rigidbody>();
				rb.isKinematic = false;
				ObjectInArea = false;
				rnd = null;
				isHolding = false;
			}
		}
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Collide" && !isHolding){
			rnd = other.gameObject;
			ObjectInArea = true;
		}
	}

	void OnTriggerExit(Collider other){
		if(!isHolding){
			ObjectInArea = false;
			rnd = null;
		}
	}
}