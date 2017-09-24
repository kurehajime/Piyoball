using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closureController : MonoBehaviour {
	Rigidbody2D rigi2d;

	// Use this for initialization
	void Start () {
		rigi2d = GetComponent<Rigidbody2D> ();
		rigi2d.angularVelocity = 15;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
