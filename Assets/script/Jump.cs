using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float jumpHeight;
	public Rigidbody2D rb;
	private bool canJunp = true;
	private Animator anim;



	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	void OnCollisionStay2D(Collision2D hit){
		anim.SetBool ("Push_button", false); 
		if (Input.GetKeyDown("space") && canJunp) {
			// Spaceが押され続けてる！
			anim.SetBool ("Push_button", true); 
			rb.AddForce(Vector3.up * 1000.0f * jumpHeight);
			canJunp = false;
		}
	}
	void OnCollisionExit2D(Collision2D hit){
		canJunp = true;
	}
}
	