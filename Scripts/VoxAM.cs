using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxAM : MonoBehaviour {
    public AnimationCurve ac;
    Vector3 s;
    public float playspeed = 3;
    float timeOFFset;
	// Use this for initialization
	void Start () {
        s = transform.localScale;
        timeOFFset = Random.value;
	}
	
	// Update is called once per frame
	void Update () {
        timeOFFset += Time.deltaTime;
        float r = ac.Evaluate(timeOFFset*playspeed);
        transform.localScale = new Vector3(s.x, s.y*r, s.z);
	}
}
