using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {

	public int meter = 100;
	public int player;
	public float movementSpeed = 1.0f;
	public Transform barrel;
	public GameObject bullet;
	public GameObject gm;
	private GameManager gm1;
	public string key;

	// Use this for initialization
	void Start () {
		gm1 = gm.GetComponent<GameManager> ();
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

		if (Input.GetKeyDown (key)) {
			Instantiate (bullet, barrel.position, barrel.rotation);
		}

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
				Vector3 movement = new Vector3 (0.0f, 0.0f, 1.0f);
				transform.Translate (movementSpeed * movement);
			}
			if (Input.GetKey (KeyCode.S)) {
				Vector3 movement = new Vector3 (0.0f, 0.0f, -1.0f);
				transform.Translate (movementSpeed * movement);
			}
			if (Input.GetKey (KeyCode.A)) {
				transform.Rotate (Vector3.up * -1.0f, Space.Self);
			}
			if (Input.GetKey (KeyCode.D)) {
				transform.Rotate (Vector3.up * 1.0f, Space.Self);
			}
		} else {
			if (Input.GetKey ("up")) {
				Vector3 movement = new Vector3 (0.0f, 0.0f, 1.0f);
				transform.Translate (movementSpeed * movement);
			}
			if (Input.GetKey ("down")) {
				Vector3 movement = new Vector3 (0.0f, 0.0f, -1.0f);
				transform.Translate (movementSpeed * movement);
			}
			if (Input.GetKey ("left")) {
				transform.Rotate (Vector3.up * -1.0f, Space.Self);
			}
			if (Input.GetKey ("right")) {
				transform.Rotate (Vector3.up * 1.0f, Space.Self);
			}
		}

	}
}
