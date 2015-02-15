using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float speed;
	public GameManager gameManager;
	public float jump;
	public bool InAir=false;
	// Use this for initialization
	void Start () 
	{
		//Debug.Log("ik ben awake"); 
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis ("Vertical");
		
		Vector3 pos = new Vector3 (x, 0f, z);
		rigidbody.AddForce (pos * speed);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Collectable") 
		{
			gameManager.AddCollectable();
			Destroy(other.gameObject);
		}
	}
	
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Floor"&&InAir==true){
			InAir = false;
		}
	}
	
	void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Floor" && InAir == true) {
			InAir = false;
		}
	}
	
	void OnCollisionExit(Collision other)
	{
		InAir = true;
	}
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)&&InAir==false) 
		{
			this.rigidbody.AddForce(new Vector3(0,jump,0));
		}
	}
}
