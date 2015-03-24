using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour 
{
	public int level;
	public bool open;

	public GameObject EnterIcon;
	public GameObject LockedIcon;

	public LevelLoader loaderController;

	void Start()
	{
		loaderController = GameObject.FindGameObjectWithTag ("LevelController").GetComponent<LevelLoader> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			if(open)
			{
				EnterIcon.SetActive (true);

				if(Input.GetKeyDown(KeyCode.Space))
				{
					loaderController.LoadLevel (level);
				}
			}
			else
			{
				EnterIcon.SetActive (false);
			}
		}
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			if(open)
			{
				if(Input.GetKeyDown(KeyCode.Return))
				{
					loaderController.LoadLevel (level);
				}
			}
		}
	
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			EnterIcon.SetActive (false);
		}
	}
	void Update()
	{
		if(!open)
		{
			LockedIcon.SetActive (true);
		}
		else
		{
			LockedIcon.SetActive (false);
		}
	}
}
