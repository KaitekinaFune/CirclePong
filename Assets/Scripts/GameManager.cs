using UnityEngine;

public class GameManager : MonoBehaviour
{
	public Transform gameOverUI;

	private void Start()
	{
		OnGameStart();
	}

	private void OnEnable()
	{
		BallController.gameOver += OnGameOver;

		PlayerController.restartGame += OnGameStart;
	}

	private void OnDisable()
	{
		BallController.gameOver -= OnGameOver;

		PlayerController.restartGame -= OnGameStart;
	}

	void OnGameOver()
	{
		gameOverUI.gameObject.SetActive(true);
	}

	void OnGameStart()
	{
		gameOverUI.gameObject.SetActive(false);
	}
}
