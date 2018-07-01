using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDmg : MonoBehaviour {
	public GameObject ScoreReceiver;

    void OnTriggerEnter(Collider coll){
        if (coll.tag == "Enemy")
        {
            coll.GetComponent<FCtrl>().Hurt();
			ScoreReceiver.GetComponent<ScoreManager>().score+=1;
        }

		if(coll.tag == "RedComet"){
			coll.GetComponent<RedCometCtrl>().Hurt();
			ScoreReceiver.GetComponent<ScoreManager>().score+=1;
		}

    }
}
