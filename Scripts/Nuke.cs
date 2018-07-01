using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nuke : MonoBehaviour {
	GameObject[] gameObjects;
	public GameObject blood;
	public GameObject ScoreReceiver;
	public Text state;

	// Use this for initialization
	public void onkEvent()
	{
		if (ScoreReceiver.GetComponent<ScoreManager> ().score>30) {
			DestroyAllObjects();
			state.text = "WE MARCH FOR MACRAGGE!!!!";
			StartCoroutine (EAT(1f));
		}
	}

	public void DestroyAllObjects()
	{
		gameObjects = GameObject.FindGameObjectsWithTag ("Enemy");

		for(var i = 0 ; i < gameObjects.Length ; i ++)
		{
			Destroy(gameObjects[i]);
			Instantiate(blood,gameObjects[i].transform.position,Quaternion.identity);

		}
		ScoreReceiver.GetComponent<ScoreManager>().score-=15;
	}
	IEnumerator EAT (float time )
	{
		yield return new WaitForSeconds(time);
		state.text = "";
	}
}
