using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RemHealth : MonoBehaviour {

	public int HP = 3;

	public string LevelToLoad;

	void OnTriggerEnter(Collider coll){
		if (coll.tag == "Enemy")
		{
			coll.GetComponent<FCtrl>().Hurt();
			HP--;
		}

		if (coll.tag == "RedComet")
		{
			coll.GetComponent<RedCometCtrl>().Hurt();
			HP--;
		}

		if (HP <= 0) {
			saveScore ();
			//SceneManager.LoadSceneAsync(LevelToLoad);
			SceneManager.LoadScene(LevelToLoad);
		}
	}

	void saveScore()
	{
		PlayerPrefs.SetInt ("score", LevelManager.lm.GetComponent<ScoreManager>().score);
	}
}
