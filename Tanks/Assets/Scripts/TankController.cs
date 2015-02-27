using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {

	public int player;
	public float movementSpeed = 1.0f;
	public Transform barrel;
	public GameObject bullet;
	public GameObject gm;
	private GameManager gm1;

	// Use this for initialization
	void Start () {
		gm1 = gm.GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (gm1 != null) {
			if (gm1.getPlayerTurn () == player) {
				if (Input.GetKeyDown ("space")) {
					Instantiate (bullet, barrel.position, barrel.rotation);
					//gm1.setPlayerTurn((player % 2) + 1);
				}
			}
		}

	}

	void FixedUpdate()
	{
		if (gm1 != null) {

			if (gm1.getPlayerTurn () == player) {
				float moveHorizontal = Input.GetAxis ("Horizontal");
				float moveVertical = Input.GetAxis ("Vertical");

				Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);
				//rigidbody.velocity = movement * movementSpeed;

				transform.Rotate (Vector3.up * moveHorizontal, Space.Self);
				transform.Translate (movement * movementSpeed);
			}
		}

	}
}
