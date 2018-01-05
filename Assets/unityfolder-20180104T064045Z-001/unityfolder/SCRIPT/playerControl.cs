using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {
	//public GameObject bird;
	public Vector2 jumpForce;
	// Use this for initialization
	void Start () {
		jumpForce = new Vector2 (10f, 200f);
	}
	void OnTriggerEnter()
	{
		print("get points");
	}	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			GetComponent<Rigidbody2D> ().AddForce (jumpForce);
		}
	}
}
