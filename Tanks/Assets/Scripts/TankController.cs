using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {

	private int reload;
	public int coolDown = 100;
	public int meter = 100;
	public int player;
	public float movementSpeed = 1.0f;
	public Transform barrel;
	public GameObject bullet;
	public GameObject gm;
	private GameManager gm1;
	public string key;
	private bool isGrounded = true;

	// Use this for initialization
	void Start () {
		gm1 = gm.GetComponent<GameManager> ();
		reload = coolDown;
	}
	
	// Update is called once per frame
	void Update () {
//		if (gm1 != null) {
//			if (gm1.getPlayerTurn () == player) {
//				if (Input.GetKeyDown (key)) {
//					Instantiate (bullet, barrel.position, barrel.rotation);
//					meter -= 30;
//				}
//			}
//		}
//
//		if (meter <= 0) {
//			meter = 100;
//			gm1.changeTurn();
//		}
		if (reload >= coolDown) {
			if (Input.GetKeyDown (key)) {
				Instantiate (bullet, barrel.position, barrel.rotation);
				reload = 0;
			}
		} else {
			reload++;
		}

	}

	public void setState(bool grounded)
	{
		isGrounded = grounded;
	}

	void FixedUpdate()
	{
//		if (gm1 != null) {
//
//			if (gm1.getPlayerTurn () == player) {
//				float moveHorizontal = Input.GetAxis ("Horizontal");
//				print(moveHorizontal);
//				float moveVertical = Input.GetAxis ("Vertical");
//				print (moveVertical);
//
//				Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);
//				//rigidbody.velocity = movement * movementSpeed;
//
//				transform.Rotate (Vector3.up * moveHorizontal, Space.Self);
//				transform.Translate (movement * movementSpeed);
//			}
//		}

		if (player == 1) {
			if (Input.GetKey (KeyCode.W)) {
				//if (isGrounded == true) {
					Vector3 movement = new Vector3 (0.0f, 0.0f, 1.0f);
					transform.Translate (movementSpeed * movement);
				//}
//				else{
//					transform.Rotate (Vector3.right * 1.0f, Space.World);
//				}
			}
			if (Input.GetKey (KeyCode.S)) {
//				if (isGrounded == true) {
					Vector3 movement = new Vector3 (0.0f, 0.0f, -1.0f);
					transform.Translate (movementSpeed * movement);
//				}
//				else {
//					transform.Rotate (Vector3.right * -1.0f, Space.World);
//				}
			}
			if (Input.GetKey (KeyCode.A)) {
				//if (isGrounded == true) {
					transform.Rotate (Vector3.up * -1.0f, Space.World);
//				}
//				else {
//					transform.Rotate (Vector3.up * -1.0f, Space.World);
//				}
			}
			if (Input.GetKey (KeyCode.D)) {
				//if (isGrounded == true) {
					transform.Rotate (Vector3.up * 1.0f, Space.World);
//				}
//				else {
//					transform.Rotate (Vector3.up * 1.0f, Space.World);
//				}
			}
		} else {
			if (Input.GetKey ("up")) {
				//if (isGrounded == true) {
					Vector3 movement = new Vector3 (0.0f, 0.0f, 1.0f);
					transform.Translate (movementSpeed * movement);
//				}
//				else{
//					transform.Rotate (Vector3.right * 1.0f, Space.World);
//				}
			}
			if (Input.GetKey ("down")) {
//				if (isGrounded == true) {
					Vector3 movement = new Vector3 (0.0f, 0.0f, -1.0f);
					transform.Translate (movementSpeed * movement);
//				}
//				else {
//					transform.Rotate (Vector3.right * -1.0f, Space.World);
//				}
			}
			if (Input.GetKey ("left")) {
//				if (isGrounded == true) {
					transform.Rotate (Vector3.up * -1.0f, Space.World);
//				}
//				else {
//					transform.Rotate (Vector3.up * -1.0f, Space.World);
//				}
			}
			if (Input.GetKey ("right")) {
//				if (isGrounded == true) {
					transform.Rotate (Vector3.up * 1.0f, Space.World);
				//}
//				else {
//					transform.Rotate (Vector3.up * 1.0f, Space.World);
//				}
			}
		}

	}
}
