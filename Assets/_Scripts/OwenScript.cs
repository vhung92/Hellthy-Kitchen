using UnityEngine;
using System.Collections;

public class OwenScript : MonoBehaviour {

	public ParticleSystem Fire;

	void Start (){
		Fire.enableEmission = false;
	}

	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		StartCoroutine(Rotate(Vector3.forward * 90f, 3f)) ;
		Fire.enableEmission = true;
	}

	IEnumerator Rotate(Vector3 byAngles, float inTime)
	{
		Quaternion fromAngle = transform.rotation ;
		Quaternion toAngle = Quaternion.Euler(transform.eulerAngles + byAngles) ;
		for(float t = 0f ; t < 1f ; t += Time.deltaTime/inTime)
		{
			transform.rotation = Quaternion.Lerp(fromAngle, toAngle, t) ;
			yield return null ;
		}
	}

}
