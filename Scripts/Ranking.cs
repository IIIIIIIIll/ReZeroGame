using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {

	public Text score;
	int yourScore;
	int highScore;
	// Use this for initialization
	void Start () {
		yourScore = PlayerPrefs.GetInt ("score", 0);
		highScore = PlayerPrefs.GetInt ("highScore", 0);
		if (yourScore > highScore) {
			PlayerPrefs.SetInt ("highScore", yourScore);
		} else {
			PlayerPrefs.SetInt ("highScore", highScore);
		}
		PlayerPrefs.SetInt ("score", 0);
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "\nYour Score\n"+yourScore+"\nHighest Score\n"+highScore+"\n";

		if (yourScore > highScore) {
			score.text+="WoW! You break the record!";
		}
		else if(yourScore==0)
		{
			score.text+="Oh! Hello World!";
		}
		else if (yourScore <=5) {
			score.text+="Pick up those potions. Restore HP";
		}
		else if (yourScore >5&&yourScore<=10) {
			score.text+="Weird…Where are those potions come from?";
		}
		else if (yourScore >10&&yourScore<=20) {
			score.text+="Only ball can knock down enemies";
		}else if (yourScore >20&&yourScore<=30) {
			score.text+="It's the weapon's fault!";
		}else if (yourScore >30&&yourScore<=40) {
			score.text+="Spinning!";
		}else if (yourScore > highScore-3) {
			score.text+="Very Close! Try Again!";
		}

			
	}

	public void clean (){
		PlayerPrefs.DeleteKey ("score");
		PlayerPrefs.DeleteKey ("highScore");
	}

}
