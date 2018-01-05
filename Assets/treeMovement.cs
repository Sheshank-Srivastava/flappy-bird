using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeMovement : MonoBehaviour {
	public Vector2 speed = new Vector2(-2,0f); 
	float height=0;
	// Use this for initialization
	void Start () {
		height = Random.Range(0.76f,1.11f);
		transform.position = new Vector3 (transform.position.x, -3.39f, transform.position.z);	
		transform.localScale = new Vector3 (height, height, transform.localScale.z);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = speed;
	}
}
