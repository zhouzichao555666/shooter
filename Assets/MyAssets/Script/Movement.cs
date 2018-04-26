using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


	public float speed = 2.0f;
	public float gravity = -9.8f;
	public Camera cam;


	private Animator playerm;
	private CharacterController charcon;
	public Transform rightGunBone;
	public Transform leftGunBone;

	public Getguns[] getguns;

	public static int isFire=0;




	// Use this for initialization
	void Start () {
	
		charcon = GetComponent<CharacterController> ();

		playerm = GetComponent<Animator> ();




	}
	// Update is called once per frame
	void Update () {

		float dx = Input.GetAxis ("Horizontal") * speed;
		float dz = Input.GetAxis ("Vertical") * speed;

		Vector3 movement = new Vector3 (dx,0,dz);

		movement = Vector3.ClampMagnitude (movement, speed);
		movement.y = gravity;

		movement *= Time.deltaTime;
		movement = transform.TransformDirection (movement);

		charcon.Move (movement);
		animating (dx,dz);



		if(GetGun.isGetgun==1 && GetGun.name== 1){


			setGetguns ("getgun");


		}

		if(GetGun.isGetgun==1 && GetGun.name== 2 ){


			setGetguns ("getgun2");


		}


		
	}





	void animating( float h, float v){




		if (Input.GetKey ("left shift")) {

			playerm.SetBool ("isWalk", false);

			bool runing = h != 0f || v != 0f;

			playerm.SetBool ("isRun", runing);
			speed = 4.0f;

		
		} else {


			playerm.SetBool ("isRun", false);

			speed = 2.0f;



			bool walking = h != 0f || v != 0f;

			playerm.SetBool ("isWalk", walking);

		}


		if (Input.GetMouseButtonDown (0)) {

			playerm.SetBool ("isFire", true);


			if(GetGun.isaim==1){

//			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
//
//				Debug.DrawRay (ray.origin,ray.direction*10,Color.white);

			Debug.Log ("asdfa");


				isFire=1;  




				Invoke("shutshoot", 1f);

			
			}






		} 

		if (Input.GetMouseButtonUp (0)) {
		
			playerm.SetBool ("isFire",false);
			playerm.SetBool ("isIdle", true);
		
		}

		if (h == 0f && v == 0f) {

			playerm.SetBool ("isIdle", true);




		} else {
		
			playerm.SetBool ("isIdle",false);
		
		}




	}



	void setGetguns(string name){

		foreach (Getguns hand in getguns) {
			if (hand.name == name) {
				if (rightGunBone.childCount > 0)
					Destroy(rightGunBone.GetChild(0).gameObject);



				if (leftGunBone.childCount > 0)
					Destroy(leftGunBone.GetChild(0).gameObject);


				if (hand.rightGun != null) {
					GameObject newRightGun = (GameObject) Instantiate(hand.rightGun);
					newRightGun.transform.parent = rightGunBone;
					newRightGun.transform.localPosition = Vector3.zero;
					newRightGun.transform.localRotation = Quaternion.Euler(90, 0, 0);


				}
				if (hand.leftGun != null) {
					GameObject newLeftGun = (GameObject) Instantiate(hand.leftGun);
					newLeftGun.transform.parent = leftGunBone;
					newLeftGun.transform.localPosition = Vector3.zero;
					newLeftGun.transform.localRotation = Quaternion.Euler(90, 0, 0);

				}
				playerm.runtimeAnimatorController = hand.controller;
				GetGun.isGetgun = 0;
				return;
			}
		}
	
	
	
	}



	void shutshoot() 
	{  
		isFire = 0;  

	}  
  

	[System.Serializable]
	public struct Getguns {
		public string name;
		public GameObject rightGun;
		public GameObject leftGun;
		public RuntimeAnimatorController controller;
	}





}
