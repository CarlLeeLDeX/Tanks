using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private int player = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getPlayerTurn()
	{
		return player;
	}

	public void setPlayerTurn(int turn)
	{
		player = turn;
	}
}
