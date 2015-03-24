using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public LevelLoader loader;

	public void Quit()
	{
		Application.Quit ();
	}

	public void LevelSelect(int level)
	{
		loader.LoadLevel (level);
	}
}
