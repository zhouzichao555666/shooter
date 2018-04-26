using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsCamera : MonoBehaviour {

	// Use this for initialization






	void Start () {

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		
	}


	
	// Update is called once per frame
	void Update () {

	
		
		



		


		if (Input.GetKeyDown ("escape")) {
		
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		
		
		}

		if (Input.GetButtonDown("Fire1"))
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}



		
	}







}
