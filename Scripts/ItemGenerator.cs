using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	static public ItemGenerator hp;
	public GameObject item;
	public Transform player;
	public float ratetime = 5;
	public float myTime = 0;
	public float z = 0;
	// Use this for initialization
	void Awake () {
		hp = this;
	}

	// Update is called once per frame
	void Update () {
		myTime += Time.deltaTime;
		if (myTime > ratetime)
		{
			Vector2 r = Random.insideUnitCircle.normalized*(Random.Range(7,20));
			Instantiate(item,new Vector3(r.x,Random.Range(0,z),r.y),Quaternion.Euler(new Vector3(0,Random.Range(0.0f,360.0f),0)));
			myTime -= ratetime;
		}
	}
}
