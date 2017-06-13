using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour {

	// Use this for initialization
	void Update () {
		if ( Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene("GameMain");
		}

	}

}
