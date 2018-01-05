using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCoin : MonoBehaviour {
	public GameObject coin;
	public GameObject tree;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateCoin", 2, 5);
		InvokeRepeating ("Generatetree", 2, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void GenerateCoin(){
		Instantiate (coin);	
	}
	void Generatetree(){
		Instantiate (tree);	
	}

}
