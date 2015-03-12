using UnityEngine;
using System.Collections;

public class Display : MonoBehaviour {

	static Display instance;
	public GameObject text1;
	public GameObject text2;
	public GameObject gm;
	private GameManager gm1;
	private bool change = false;

	// Use this for initialization
	void Start () {
		gm1 = gm.GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gm1 != null) {
			if (gm1.getWinner() == 1)
			{
				text1.SetActive(true);
				text2.SetActive(false);
				change = true;
			}
			else if (gm1.getWinner() == 2)
			{
				text1.SetActive(false);
				text2.SetActive(true);
				change = true;
			}
			else
			{
				text1.SetActive(false);
				text2.SetActive(false);
			}
		}

		if (change == true) {
			if (Input.anyKeyDown)
			{
				Application.LoadLevel(0);
			}
		}
	}
}
