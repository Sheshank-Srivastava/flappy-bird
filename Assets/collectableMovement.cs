using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableMovement : MonoBehaviour {
	public Vector2 speed = new Vector2(-2,0f); 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = speed;
	}
}
