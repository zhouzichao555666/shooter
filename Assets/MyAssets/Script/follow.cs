using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	public GameObject thirdPersonPlayer;    
	public GameObject FollowCamera;         
	public float CameraSmoothTime = 0;
	private Vector3 velocity = Vector3.zero;

	public float RotateSpeed=3.0f;

	void Update()
	{
		
		float x = RotateSpeed * Input.GetAxis("Mouse X");



		thirdPersonPlayer.transform.rotation = Quaternion.Euler(
			thirdPersonPlayer.transform.rotation.eulerAngles +
			Quaternion.AngleAxis(x, Vector3.up).eulerAngles
		);


	}



	void LateUpdate(){
	
	

		float x = RotateSpeed * Input.GetAxis("Mouse X");

		FollowCamera.transform.rotation = Quaternion.Euler(
			FollowCamera.transform.rotation.eulerAngles +  
			Quaternion.AngleAxis(x, Vector3.up).eulerAngles
		);

	



		Vector3 TargetCameraPosition = thirdPersonPlayer.transform.TransformPoint(new Vector3(0f, 1.5f, -1.2f));

		FollowCamera.transform.position = Vector3.SmoothDamp(
			FollowCamera.transform.position,
			TargetCameraPosition,
			ref velocity,
			CameraSmoothTime, 
			Mathf.Infinity,
			Time.deltaTime
		);
	
	
	}


}
