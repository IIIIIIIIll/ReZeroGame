using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneControl : MonoBehaviour {

	public void loadRank(string level)
	{
		SceneManager.LoadScene(level);
	}
}
