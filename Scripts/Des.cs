using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Des : MonoBehaviour {
    public float delayTime=10;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, delayTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
