using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCtrl : MonoBehaviour {
    public Transform player;
    public float rotSpeed;
    public Vector3 vc;
    public GameObject blood;

	// Use this for initialization
	void Start () {
		if (LevelManager.lm != null) {
			player = LevelManager.lm.player;

		}
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 TargetDir = player.position-transform.position;
        float step = rotSpeed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, TargetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
        transform.Translate(Vector3.forward * Time.deltaTime * 8);
	}

    public void Hurt(){
        Destroy(gameObject);
        Instantiate(blood,transform.position,Quaternion.identity);
    }
}
