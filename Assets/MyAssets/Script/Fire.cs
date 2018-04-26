using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {


	public float time=1f;  

	private float timer;  

	public Light light;
	string     getObjName;


	public LineRenderer line;

	public GameObject Bullet;
	public Transform  BulletStart;


	void Awake(){


		
		light.enabled = false;  
		line.enabled = false;

	
	}





	// Update is called once per frame
	void LateUpdate () {




		  

		if (Movement.isFire==1)  
		{             


			Debug.Log ("adsfasxcc");

			light.enabled = true; 
//			line.SetPosition (0,transform.position);

		
			line.SetPosition(0, transform.position);

			Ray ray = new Ray(transform.position, transform.forward);  

			RaycastHit hitinfo;  


			if (Physics.Raycast (ray, out hitinfo)) {         
				
				getObjName = hitinfo.transform.name;    

				Debug.Log (getObjName);
					
			} 


//			timer -= Time.deltaTime;  
//
//			if (timer <= 0)  
//			{             
//

				Instantiate (Bullet, transform.TransformPoint(BulletStart.transform.localPosition), BulletStart.rotation);
				 
				Debug.Log (transform.TransformPoint(BulletStart.transform.localPosition));


//				timer = time;  
//
//			}  


		









//			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
//			{
//				
//			}
//			else
//			{
//				line.SetPosition(1,transform.position+transform.forward*100);
//			}


			 

		} 
		if (Movement.isFire == 0) {

			light.enabled = false;
		
			line.enabled = false; 
		
		}






	
	}
}
