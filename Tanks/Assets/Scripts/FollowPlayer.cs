using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	private GameManager gm1;
	public GameObject gm;

	// Use this for initialization
	void Start () {
		gm1 = gm.GetComponent<GameManager> ();
		if (gm1.getPlayerTurn () == 1)
			player = GameObject.Find ("Player1");
		else
			player = GameObject.Find ("Player2");
		offset = player.transform.position - transform.position;
	}

	void Update()
	{

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
