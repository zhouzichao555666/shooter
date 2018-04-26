using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class over : MonoBehaviour {

	// Use this for initialization
	GameObject player;








	void Awake(){




		player = GameObject.FindGameObjectWithTag("Player");
	

	}






	void OnTriggerStay(Collider other){



		if (other.gameObject == player) {


			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;


			SceneManager.LoadScene (2);



		}


	}
}
