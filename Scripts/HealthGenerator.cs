using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGenerator : MonoBehaviour {

	static public HealthGenerator hp;
	public GameObject HealthCoin;
	public Transform player;
	public float ratetime = 20;
	public float myTime = 0;
	// Use this for initialization
	void Awake () {
		hp = this;
	}

	// Update is called once per frame
	void Update () {
		myTime += Time.deltaTime;
		if (myTime > ratetime)
		{
			Vector2 r = Random.insideUnitCircle.normalized*(Random.Range(0,20));
			Instantiate(HealthCoin,new Vector3(r.x,0.5f,r.y),Quaternion.Euler(new Vector3(0,Random.Range(0.0f,360.0f),0)));
			myTime -= ratetime;
		}
	}
}
