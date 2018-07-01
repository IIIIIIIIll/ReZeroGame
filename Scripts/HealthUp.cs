using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour {
	public float delayTime=10;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, delayTime);
	}

	void OnTriggerEnter(Collider coll){
		if (coll.tag == "Player")
		{
			coll.GetComponent<RemHealth>().HP++;
			Destroy(gameObject);
		}
	}
}
