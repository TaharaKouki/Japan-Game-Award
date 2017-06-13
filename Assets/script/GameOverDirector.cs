using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverDirector : MonoBehaviour {

	[SerializeField]
	private Transform Player;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.position.y < -6.0f){
			SceneManager.LoadScene("GameOver");
		}
	}
}
