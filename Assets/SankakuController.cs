using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SankakuController : MonoBehaviour {
	Rigidbody2D rigi2d;
	public bool Direction = true;
	void Start () {
		rigi2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {




		if ((Input.GetKey (KeyCode.LeftArrow)&&Direction==true)
			||(Input.GetKey (KeyCode.RightArrow)&&Direction==false)
		) {
			if (Direction == true) {
				left ();
			} else {
				right ();
			}
		} else {
			back ();
		}


	}

	private void left(){
		if (Mathf.Round (transform.eulerAngles.z) < 60) {
			float speed = 60.0f - Mathf.Round (transform.eulerAngles.z);
			rigi2d.angularVelocity = 20 * speed;				
		} else {
			rigi2d.angularVelocity = 0;
		}
	}
	private void right(){
		if (Mathf.Round (transform.eulerAngles.z) > 300 || Mathf.Round (transform.eulerAngles.z) == 0) {
			float speed = Mathf.Round (transform.eulerAngles.z) != 0 ?
				Mathf.Round (transform.eulerAngles.z) - 300.0f : 60;
			rigi2d.angularVelocity = -20 * speed;
		} else {
			rigi2d.angularVelocity = 0;
		}
	}

	private void back(){
		if (Mathf.Round (transform.eulerAngles.z) < 180) {
			float speed = transform.eulerAngles.z;
			rigi2d.angularVelocity = -1 * speed * 15;
		} else if (Mathf.Round (transform.eulerAngles.z) > 180) {
			float speed = 360 - transform.eulerAngles.z;
			rigi2d.angularVelocity = 1 * speed * 15;
		} else {
			rigi2d.angularVelocity = 0;
		}
	}

}
