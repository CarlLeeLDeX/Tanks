using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	
	public GameObject player;
	private Vector3 offset;
	private GameManager gm1;
	public GameObject gm;
	//private bool change;

	// Use this for initialization
	void Start () {
		//change = false;
		gm1 = gm.GetComponent<GameManager> ();

		offset = player.transform.position - transform.position;
	}

	// Update is called once per frame
	void LateUpdate () {

//		transform.position = player.transform.position + offset;
//		transform.rotation = player.transform.rotation;
//		transform.LookAt (player.transform);
		float desiredAngle = player.transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
		transform.position = player.transform.position - (rotation * offset);
		transform.LookAt(player.transform);
	}
}
