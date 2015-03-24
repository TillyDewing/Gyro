using UnityEngine;
using System.Collections;

public class LogoDisplay : MonoBehaviour 
{
	public float time;

	private float elapsedTime;

	void Update()
	{
		elapsedTime += Time.deltaTime;

		if(elapsedTime > time)
		{
			Application.LoadLevel (1);
		}
	}
}
