using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private int player;
	private bool change;
	public Camera cam1;
	public Camera cam2;

	// Use this for initialization
	void Start () {
		player = Random.Range (1, 2);
		change = false;
		cam1.enabled = true;
		cam2.enabled = false;
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
	}

	public bool getChange() {
		return change;
	}


}
