using UnityEngine;
using System.Collections;

public class playermove : MonoBehaviour {

	private bool isRight = true;
	private Rigidbody2D rig;

	void Start()
	{
		rig = this.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () 
	{

	}

	void FixedUpdate ()
	{
		//左右キーの入力
		float h = Input.GetAxis("Horizontal");
		rig.AddForce(Vector2.right * h * 300f);
	}
}