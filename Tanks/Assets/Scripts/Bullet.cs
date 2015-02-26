using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 20.0f;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (transform.forward * speed);
		Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// Vector3 shotForce = new Vector3();
	}
}
