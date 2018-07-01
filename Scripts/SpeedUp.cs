using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour {
	// Use this for initialization
	public GameObject RemP;
	public GameObject ScoreReceiver; 
	public Text state;

	public void onckEvent(){
		if (ScoreReceiver.GetComponent<ScoreManager> ().score>9) {
			Speedup();
			state.text = "Pika! Pika! ";
			ScoreReceiver.GetComponent<ScoreManager>().score-=5;
			StartCoroutine (EAT(1f));
		}
	}

	public void Speedup () {
		RemP.GetComponent<RemCrtl>().sPeed=16;
	}

	public void Speeddown () {
		RemP.GetComponent<RemCrtl>().sPeed=8;
	}
		
	IEnumerator EAT (float time )
	{
		yield return new WaitForSeconds(time);
		Speeddown();
		state.text = ""; 
	}
}
