using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour {


	public float sensitivityHor=9.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		float delta = Input.GetAxis ("Mouse X") ;
		float rotationY = transform.localEulerAngles.y + delta;
		transform.localEulerAngles = new Vector3 (0,rotationY,0);
		
	}
}
