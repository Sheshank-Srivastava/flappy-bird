using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {
	public GameObject bird;
	public Vector2 jumpForce;
	public GameObject go;
	AudioSource coinAudio;
	int score =0;
	// Use this for initialization
	void Start () {
		jumpForce = new Vector2 (1f, 200f);
		coinAudio = GetComponent<AudioSource> ();
	}
	void OnTriggerEnter2D(Collider2D obj){
		if(obj.gameObject.CompareTag("enemy")){
			Debug.Log ("Game Over");
			Destroy (gameObject);
			go.transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
		}
		else if(obj.gameObject.CompareTag("collectable")){
			Debug.Log(++score);
			Destroy (obj.gameObject);
			coinAudio.Play();
		}
		
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			bird.GetComponent<Rigidbody2D> ().AddForce (jumpForce);
		}
	}
}
