using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour {
    static public LevelManager lm;
    public GameObject enemy;
    public Transform player;
    public float ratetime;
    public float myTime;
	public GameObject redComet;
	public GameObject ScoreReceiver; 
	int count = 0;
	public Text state;

	// Use this for initialization
	void Awake () {
        lm = this;
	}
	
	// Update is called once per frame
	void Update () {
        myTime += Time.deltaTime;
        if (myTime > ratetime)
        {
            Vector2 r = Random.insideUnitCircle.normalized*35;
            Instantiate(enemy,new Vector3(r.x,0,r.y),Quaternion.Euler(new Vector3(0,Random.Range(0.0f,360.0f),0)));
            myTime -= ratetime;
			count++;
			if (ScoreReceiver.GetComponent<ScoreManager> ().score > 30&&count>30) {
				Instantiate(redComet,new Vector3(r.x,0,r.y),Quaternion.Euler(new Vector3(0,Random.Range(0.0f,360.0f),0)));
				count = 0; 
				state.text = "Amuro...don't you know the people in the Earth are the parasites that infest the Earth?!";
				StartCoroutine (EAT(2f));
			}
        }
	}

	IEnumerator EAT (float time )
	{
		yield return new WaitForSeconds(time);
		state.text = "";
	}
}
