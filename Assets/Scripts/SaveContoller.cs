using UnityEngine;
using System.Collections;

public class SaveContoller : MonoBehaviour 
{
	public int world;
	public int level;



	void Start()
	{
		world = PlayerPrefs.GetInt ("World", 1);
		level = PlayerPrefs.GetInt ("Level", 1);
		DontDestroyOnLoad (gameObject);
	}

	public void Save()
	{
		PlayerPrefs.SetInt ("World", world);	//writes modified values then writes the player prefs to disk
		PlayerPrefs.SetInt ("Level", level); 

		PlayerPrefs.Save ();
	}

	public void ClearSaves()
	{
		world = 1;
		level = 1;

		PlayerPrefs.Save ();
	}

}
