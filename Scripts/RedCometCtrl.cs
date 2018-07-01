using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCometCtrl : MonoBehaviour {
	public Transform player;
	public float rotSpeed;
	public Vector3 vc;
	public GameObject blood;
	public int RedCometHP;

	public int time;
	int count =5;

	// Use this for initialization
	void Start () {
		if (LevelManager.lm != null) {
			player = LevelManager.lm.player;
		}

		RedCometHP = 10;
	}

	// Update is called once per frame
	void Update () {

		Vector3 TargetDir = player.position-transform.position;
		float step = rotSpeed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards(transform.forward, TargetDir, step, 0.0f);
		//Debug.DrawRay(transform.position, newDir, Color.red);
		transform.rotation = Quaternion.LookRotation(newDir);
		if (count == 0) {
			count = time;
		} else if (count < time/2) {
			transform.Translate (Vector3.forward * Time.deltaTime * 8);
			count--;
		} else {
			count--;
		}


		/*
		Vector3 TargetDir = player.position-transform.position;
		float step = rotSpeed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards(transform.forward, TargetDir, step, 0.0f);
		transform.rotation = Quaternion.LookRotation(newDir);
		transform.Translate(Vector3.forward * Time.deltaTime * 8);
		*/
	}
		

	public void Hurt(){
		RedCometHP--;
		if(RedCometHP==0){
			Destroy(gameObject);
			for (int i = 0; i < 10; i++) {
				Instantiate(blood,transform.position,Quaternion.identity);
			}
		}
		Instantiate(blood,transform.position,Quaternion.identity);
	}
}
