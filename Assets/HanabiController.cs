using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanabiController : MonoBehaviour {
	public float fadeTime = 1f;
	private float currentRemainTime;

	SpriteRenderer spr;
	// Use this for initialization
	void Start () {
		currentRemainTime = 0;
		this.spr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		currentRemainTime -= Time.deltaTime;
		if ( currentRemainTime <= 0f ) {
			return;
		}
		float alpha = currentRemainTime / fadeTime;
		var color = spr.color;
		color.a = alpha;
		spr.color = color;
	}
	public void Fire(){
		this.currentRemainTime = 1f;
	}
}
