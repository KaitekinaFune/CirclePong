using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	public Transform GameOverScreen;
	public GameOverScore _gameOver;
	public ScoreScript p1;
	public ScoreScript p2;
    void OnCollisionEnter(Collision collision)
	{


		SphereController sphere = collision.transform.GetComponent<SphereController>();
		if (sphere != null)
		{
			_gameOver.P1Score = p1.Score;
			_gameOver.P2Score = p2.Score;
			_gameOver.leftSide = collision.transform.position.x < 0;
			_gameOver.SetScore();
			GameOverScreen.gameObject.SetActive(true);
			Destroy(sphere);
		}
	}
}
