using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour 
{
	public int levelToLoad;
	public bool open;

	public GameObject EnterIcon;
	public GameObject LockedIcon;

	public LevelLoader loaderController;

	public int world;
	public int level;


	public bool levelExit;
	public int unlockWorld;
	public int unlockLevel;

	private SaveContoller saveController;

	void Start()
	{
		loaderController = GameObject.FindGameObjectWithTag ("LevelController").GetComponent<LevelLoader> ();
		saveController = GameObject.FindGameObjectWithTag ("SaveController").GetComponent<SaveContoller> ();
	}

	void Update()
	{
		if(!levelExit)
		{
			if(world > saveController.world)
			{
				open = false;
			}
			else if(world == saveController.world)
			{
				if(level > saveController.level)
				{
					open = false;
				}
			}
			else
			{
				open = true;
			}
		}





		if(!open) //check if locked then set icon acordinly
		{
			LockedIcon.SetActive (true);
		}
		else
		{
			LockedIcon.SetActive (false);
		}
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
					loaderController.LoadLevel (levelToLoad);
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
					
					if(levelExit)	//Checks if it is a level exit and saves
					{
						if(unlockWorld > saveController.world)
						{
							saveController.world = unlockWorld;
						}
						if(unlockLevel > saveController.level)
						{
							saveController.level = unlockLevel;
						}

						saveController.Save ();
					}

					loaderController.LoadLevel (levelToLoad);

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

}
