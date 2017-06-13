using System.Collections;
using UnityEngine;

public class Buff : MonoBehaviour {

		void OnCollisionEnter2D (Collision2D col)
			{
				//ユニティちゃんと衝突した時
				if (col.gameObject.tag == "Unity") {
					//アイテムを削除する
					Destroy(this.gameObject);
				}
			}
		
	}
