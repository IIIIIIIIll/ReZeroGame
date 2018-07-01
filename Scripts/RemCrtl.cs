using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RemCrtl : MonoBehaviour {
    public float sPeed = 8;
    public float SPeeD = 0;
    public float roatSPeed = 200;

	float vertical = 0;

	private CharacterController myController;

	// Use this for initialization
	void Start () {
		myController = gameObject.GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		
		#if UNITY_IOS || UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE

		if(Mathf.Abs(CrossPlatformInputManager.GetAxis("Vertical"))>0)
		{
			vertical = 1;
		}
		else
		{
			vertical = 0;
		}
	
		// Determine how much should move in the z-direction
		Vector3 movementZ = vertical*Vector3.forward * (sPeed - SPeeD) * Time.deltaTime;

		Vector3 movement = transform.TransformDirection(movementZ);

		myController.Move(movement);


		float y = CrossPlatformInputManager.GetAxis("Vertical");
		float x = CrossPlatformInputManager.GetAxis("Horizontal");

		float direction= 0;

		// Feasible, but rotate too fast would cause problem
		if(y>=0&&x>0)
		{
			Debug.Log(direction=  90-Mathf.Atan(y/x)*180/Mathf.PI);
		}
		else if(y>=0&&x<0)
		{
			Debug.Log(direction=  360-90-Mathf.Atan(y/x)*180/Mathf.PI);
		}
		else if(y<0&&x<=0)
		{
			Debug.Log(direction= 360-90-Mathf.Atan(y/x)*180/Mathf.PI);
		}
		else if (y<0&&x>=0)
		{
			Debug.Log(direction = 90-Mathf.Atan(y/x)*180/Mathf.PI);
		}
	
		float current = transform.localEulerAngles.y;
		Debug.Log(transform.localEulerAngles.y);



		transform.localEulerAngles = new Vector3(
			0,
			direction,
			0
		);


		//previous = direction;


		/*
		if(compare >=180)// D
		{
			transform.Rotate (Vector3.up * Time.deltaTime * roatSPeed);
			direction = previous+Vector3.up * Time.deltaTime * roatSPeed;
			if(direction>360)
			{
				direction-=360;
			}
		}
		else if (compare>0&&compare<180) // A
		{
			transform.Rotate (Vector3.down * Time.deltaTime * roatSPeed);
			direction = previous - Vector3.down * Time.deltaTime * roatSPeed;
		}
		*/




		//direction= (direction + previous)/2;



		#elif  UNITY_STANDALONE || UNITY_WEBPLAYER


		transform.position += transform.forward * SPeeD * Time.deltaTime;
		if (Input.GetKey (KeyCode.W))  {
			transform.position += transform.forward * (sPeed - SPeeD) * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S) ) {
			transform.position -= transform.forward * (sPeed + SPeeD) * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A) ) {
			transform.Rotate (Vector3.down * Time.deltaTime * roatSPeed);
		}
		if (Input.GetKey (KeyCode.D) ){
			transform.Rotate (Vector3.up * Time.deltaTime * roatSPeed);
		}

		#endif
	}

	public void  getSpeed(int spd){
		sPeed = spd;
	}
}
