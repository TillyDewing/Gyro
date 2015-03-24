using UnityEngine;
using System.Collections;

public class LevelRotator : MonoBehaviour 
{
	
	public float rotateSpeed;

	private Transform level;

	void Start()
	{
		level = GameObject.FindGameObjectWithTag ("LevelRoot").transform;
	}

	void Update()
	{
		if(Input.GetMouseButton (0))
		{
			level.RotateAround (transform.position, Vector3.forward, rotateSpeed * Time.deltaTime);

//			level.Rotate (new Vector3 (0,0,rotateSpeed * Time.deltaTime));
		}
		else if(Input.GetMouseButton (1))
		{
			level.RotateAround (transform.position, -Vector3.forward, rotateSpeed * Time.deltaTime);

//			level.Rotate (new Vector3 (0,0,-rotateSpeed * Time.deltaTime));
		}
	}

}
