using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			Application.LoadLevel (0);
		}
		
	}
}
