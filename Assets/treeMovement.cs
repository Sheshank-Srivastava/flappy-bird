using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeMovement : MonoBehaviour {
	public Vector2 speed = new Vector2(-1,0f); 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = speed;
	}
}
