using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttlemove : MonoBehaviour {

	// Use this for initialization
	public float Speed;

	void Start () {
		GetComponent<Rigidbody>().velocity = transform.up * Speed;
	}
}
