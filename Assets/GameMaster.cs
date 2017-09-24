using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {
	GameObject piyoYellow;
	GameObject goal;
	GameObject hanabi;
	Vector3 start = new Vector3 (-8, 1, 0);

	// Use this for initialization
	void Start () {
		this.piyoYellow = GameObject.Find ("piyoYellow");
		this.goal = GameObject.Find ("goal");
		this.hanabi = GameObject.Find ("hanabi");
	}
	
	// Update is called once per frame
	void Update () {
		if (piyoYellow.transform.position.y < -20) {
			piyoYellow.transform.position = start;
			piyoYellow.GetComponent<Rigidbody2D> ().velocity = Vector3.zero;
		}
		if (isGoal ()) {
			if (Random.Range ((int)0, (int)2) < 0.5) {
				piyoYellow.GetComponent<Rigidbody2D> ().velocity = new Vector3 (-80, -80, 0);
			} else {
				piyoYellow.GetComponent<Rigidbody2D> ().velocity = new Vector3 (-80, -80, 0);
			}
			this.hanabi.GetComponent<HanabiController> ().Fire ();
		}
	}

	bool isGoal(){
		var mag = (piyoYellow.transform.position - goal.transform.position).magnitude;

		if (mag <= 1) {
			var velo=piyoYellow.GetComponent<Rigidbody2D> ().velocity.magnitude;
			if(velo<2.0f){
				return true;
			}
		}
		return false;
	}
}
