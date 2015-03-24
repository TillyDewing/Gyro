using UnityEngine;
using System.Collections;

public class BallContainer : MonoBehaviour 
{
	public Exit exit;
	public GameObject ball;

	void Start()
	{
		Debug.Log ("Start");
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("Enter");
		if(other.gameObject.tag == "Ball")
		{
			Vector3 loc = other.transform.position;
			Vector3 rot = other.transform.rotation.eulerAngles;

			SpriteRenderer rend = other.GetComponent<SpriteRenderer>();
			rend.enabled = false;

			Destroy(other);

			GameObject newBall = Instantiate (ball, loc, Quaternion.Euler (rot)) as GameObject;

			newBall.transform.parent = GameObject.FindWithTag ("LevelRoot").transform;

			Debug.Log("stopped");

			exit.open = true;
		}
	}

}
