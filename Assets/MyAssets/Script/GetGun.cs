using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGun : MonoBehaviour {



	GameObject player;


	public static int isGetgun=0;

	public static int isaim=0;

	public static int name=0;

	public int tem=0;





	void Awake(){
	


	
		player = GameObject.FindGameObjectWithTag("Player");
		Debug.Log (player);
	
	}
	





	void OnTriggerStay(Collider other){


	
		if (other.gameObject == player) {


		
			if(Input.GetKey("f")){

				Destroy (gameObject,0f);
				isGetgun= 1;
				isaim = 1;
				name = tem;

			}
		
		
		}
	
	
	}






}
		