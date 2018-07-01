using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager sm;

	public Text state;
	public int score;
	public GameObject RemP;

	
	// Update is called once per frame
	void Update () {
		state.text = "HP:   " + RemP.GetComponent<RemHealth> ().HP+"\t Score:   " + score;
		//Score.text = "Score:   " + score;
	}
}
