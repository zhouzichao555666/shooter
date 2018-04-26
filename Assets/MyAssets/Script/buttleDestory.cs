using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttleDestory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		Destroy (gameObject,5);
	



	}



void OnTriggerEnter( Collider GetObj)
{
	if (GetObj != null)
		Destroy (gameObject);
}
}
