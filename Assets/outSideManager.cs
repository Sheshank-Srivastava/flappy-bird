﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outSideManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D obj){
		Destroy (obj.gameObject);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
