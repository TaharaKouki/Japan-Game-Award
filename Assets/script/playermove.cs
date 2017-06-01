using UnityEngine;
using System.Collections;

public class playermove : MonoBehaviour {

	private bool isRight = true;
	private Rigidbody2D rig;
	private Animator anim;

	void Start()
	{
		rig = this.GetComponent<Rigidbody2D> ();
		anim = this.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxis("Horizontal");
		rig.AddForce(Vector2.right * h * 300f);

		anim.SetFloat("Dash",h);

	}

	//void FixedUpdate ()
	//{
		//左右キーの入力
	//}
}