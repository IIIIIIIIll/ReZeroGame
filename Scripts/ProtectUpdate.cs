using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProtectUpdate : MonoBehaviour {

	public GameObject ScoreReceiver;
	public GameObject RemP;
	public Text state;
	// Update is called once per frame
	public void onckEvent () {
		if (ScoreReceiver.GetComponent<ScoreManager> ().score>20) {
			ScoreReceiver.GetComponent<ScoreManager>().score-=10;
			RemP.GetComponent<RemHealth>().HP+=3;
			state.text = "After all, our goal each year should be to increase the NUMBER of goals we set for ourselves!";
			StartCoroutine (EAT(2f));
		}
	}

	IEnumerator EAT (float time )
	{
		yield return new WaitForSeconds(time);
		state.text = "";
	}
}
