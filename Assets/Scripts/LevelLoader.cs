using UnityEngine;
using System.Collections;


public class LevelLoader : MonoBehaviour 
{
	public GameObject screen;

	void Start()
	{
		DontDestroyOnLoad (gameObject);
		DontDestroyOnLoad (screen);
	}

	public void LoadLevel(int levelIndex)
	{
		screen.SetActive (true);

		Application.LoadLevel (levelIndex);

		screen.SetActive (false);

		Destroy (screen);
		Destroy (gameObject);
	}
}
