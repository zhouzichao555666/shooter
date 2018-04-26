using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine;    
using UnityEngine.EventSystems;    
using System.Collections;   

public class ui : MonoBehaviour,IPointerDownHandler{

	// Use this for initialization

	public int uit=0; 

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void OnPointerDown (PointerEventData eventData)    
	{    
		if (uit == 1) { 
			Debug.Log ("adfa");
			SceneManager.LoadScene (1);
		}

		if(uit==2)
			SceneManager.LoadScene (2);
		
		if(uit==3)
			SceneManager.LoadScene(0);
		if (uit == 4) {
			Debug.Log ("over");
			Application.Quit ();
		}

	}  





}
