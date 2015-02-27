using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private int player;
	private bool change;
	public Camera cam1;
	public Camera cam2;

	// Use this for initialization
	void Start () {
		player = Random.Range (0, 100);
		//player = 1;
		if (player >= 50)
			player = 2;
		else
			player = 1;

		if (player == 1) {
			cam1.enabled = true;
			cam2.enabled = false;
		} else {
			cam1.enabled = false;
			cam2.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getPlayerTurn()
	{
		return player;
	}

	public void changeTurn()
	{
		cam1.enabled = !cam1.enabled;
		cam2.enabled = !cam2.enabled;
		if (player == 1)
			player = 2;
		else
			player = 1;
		Debug.Log (player);
	}

	public bool getChange() {
		return change;
	}


}
