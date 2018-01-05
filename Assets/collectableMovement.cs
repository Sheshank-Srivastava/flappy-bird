using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableMovement : MonoBehaviour {
	public Vector2 speed = new Vector2(-2,0f); 
	float stage=0;
	// Use this for initialization
	void Start () {
		stage = Random.Range(-1.96f,3.3f);
		transform.position = new Vector3 (transform.position.x, stage, transform.position.z);	
	}
		// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = speed;
	}
}
