using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public LevelLoader loader;
	private SaveContoller saveController;

	void Start()
	{
		saveController = GameObject.FindGameObjectWithTag ("SaveController").GetComponent<SaveContoller> ();
	}

	public void Quit()
	{
		Application.Quit ();
	}

	public void LevelSelect(int level)
	{
		loader.LoadLevel (level);
	}

	public void ClearSaves()
	{
		saveController.world = 1;
		saveController.level = 1;
		
		PlayerPrefs.Save ();
	}
}
