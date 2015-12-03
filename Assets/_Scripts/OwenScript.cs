using UnityEngine;
using System.Collections;

public class OwenScript : MonoBehaviour {
	private bool isOn = false;
	public ParticleSystem Fire;

	void Start (){
		Fire.enableEmission = false;
	}

	void OnTriggerEnter(Collider other){
		if(!isOn){
			StartCoroutine(Rotate(Vector3.forward * 90f, 0.5f)) ;
			Fire.enableEmission = true;
			isOn = true;
			return;
		}
		else if(isOn){
			StartCoroutine(Rotate(Vector3.forward * -90f, 0.5f)) ;
			Fire.enableEmission = false;
			isOn = false;
			return;
		}
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
