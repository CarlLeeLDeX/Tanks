using UnityEngine;
using System.Collections;

public class CheckGrounded : MonoBehaviour {

	public GameObject tank;
	private TankController tc;

	// Use this for initialization
	void Start () {
		tc = tank.GetComponent<TankController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Ground") {
			collider.gameObject.SendMessage ("setState", true, SendMessageOptions.DontRequireReceiver);
		} else {
			if (tc != null)
			{
				tc.setState(false);
			}
		}
	}
}
