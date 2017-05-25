using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float jumpHeight;
	public Rigidbody2D rb;
	private bool canJunp = true;

	// Use this for initialization
//	void Start () 
//	{
//		rb = GetComponent<Rigidbody>();
//	}
	
	// Update is called once per frame

//	void Update()
//	{
//		float gravity = 1;
//		float time = 1.5f;

//		rb.AddForce(Vector3.up * Mathf.Sqrt(2*jumpHeight*gravity));

//		if (Input.GetKey("Space")) {
//			// Spaceが押され続けてる！
//			rb.AddForce(Vector3.up * Mathf.Sqrt(2*jumpHeight*gravity));
//		}

		
//	}
	void OnCollisionStay2D(Collision2D hit){
		if (Input.GetKeyDown("space") && canJunp) {
			// Spaceが押され続けてる！
			Debug.Log(Vector3.up * jumpHeight);
			rb.AddForce(Vector3.up * 1000.0f * jumpHeight);
			canJunp = false;
		}
	}
	void OnCollisionExit2D(Collision2D hit){
		canJunp = true;
	}
}
