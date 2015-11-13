using UnityEngine;
using System.Collections;

public class HandController : MonoBehaviour {
	private float zDistance = 0;
    // Use this for initialization
    void Start () {
	
    }

    // Update is called once per frame
    void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 position = ray.GetPoint (10);
		zDistance -= Input.GetAxis("Mouse ScrollWheel");
		Vector3 new_position = new Vector3(position.x, zDistance, position.y);
		this.transform.position = new_position;


//		this.transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (mouse.x, mouse.y, zDistance));
    }
}