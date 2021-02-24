using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScript : MonoBehaviour
{
    public bool isMultiplayer = false;
 
	public void HandleInputData(int val)
	{
		Debug.Log(val);
		if (val == 0)
		{
			isMultiplayer = false;
		}
		else if (val == 1)
		{
			isMultiplayer = true;
		}
	}

	public void StartGame()
	{
		SceneManager.LoadScene(isMultiplayer ? 2 : 1);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}
}
