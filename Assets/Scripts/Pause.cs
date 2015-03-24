using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{
	public GameObject pauseMenu;
	public LevelLoader loader;
	private bool paused;
	private
	void Update()
	{
		if(Input.GetKeyDown (KeyCode.Escape))
		{
			if(paused)
			{
				Time.timeScale = 1;
				paused = false;
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				pauseMenu.SetActive (false);
			}
			else
			{
				Time.timeScale = 0;
				paused = true;
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				pauseMenu.SetActive(true);
			}

		}
		if(!paused)
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}

	}
	public void Quit()
	{
		Time.timeScale = 1;
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		pauseMenu.SetActive (false);
		
		loader.LoadLevel (0);

	}

	public void Resume()
	{
		if(paused)
		{
			Time.timeScale = 1;
			paused = false;
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			pauseMenu.SetActive (false);
		}
	}

	public void LevelSelect(int level)
	{
		Time.timeScale = 1;
		paused = false;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		pauseMenu.SetActive (false);

		loader.LoadLevel (level);

	}
}
