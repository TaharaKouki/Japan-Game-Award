using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
	private bool canGetItem = true;
	Transform player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Unity").GetComponent<Transform>();


	
		
	}
	
	// Update is called once per frame
	void Update () {
		float r = 3;
		if (Input.GetKeyDown("return")&&canGetItem&&transform.position.x - player.position.x>r) {
			//unityちゃんがrの範囲内にいる
			Debug.Log (transform.position.x - player.position.x);
			canGetItem = true ;
			



		}
	}
}