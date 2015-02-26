using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {

	public float movementSpeed = 5.0f;
	//private Vector3 moveDirection = new Vector3(0,0,0);
	public Transform barrel;
	public GameObject bullet;
	public float bulletSpeed = 20.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("space")) {
			Instantiate(bullet, barrel.position, barrel.rotation);
		}
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);
		rigidbody.velocity = movement * movementSpeed;

		transform.Rotate (Vector3.up * moveHorizontal, Space.Self);

	}
}
