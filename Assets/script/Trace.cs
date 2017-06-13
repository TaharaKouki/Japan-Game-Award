using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trace : MonoBehaviour {
	SpriteRenderer MainSpriteRenderer;
	// publicで宣言し、inspectorで設定可能にする
	public Sprite StandbySprite;
	public Sprite toresuru_material_nonesprite;
	public Sprite SlashSprite;
	GameObject playerObj;


	void Start ()
	{
		playerObj=GameObject.Find("Unity");
		// このobjectのSpriteRendererを取得
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}

	void Update ()
	{
		if (Input.GetKeyDown("return")&&Vector3.Distance(playerObj.transform.position,transform.position)<3){
			MainSpriteRenderer.sprite = toresuru_material_nonesprite;
		}

	}
		
}
