using UnityEngine;
using System.Collections;

public class TestController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.PageUp)){
			Debug.Log ("PageUp");
		}
		if(Input.GetKey (KeyCode.PageDown)){
			Debug.Log ("PageDown");
		}
	}
}
