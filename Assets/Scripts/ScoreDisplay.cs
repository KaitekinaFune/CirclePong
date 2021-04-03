using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    int score;
    int highscore;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI gameOverScoreText;

	private void Start()
	{
        OnGameStart();
	}

	private void OnGameStart()
	{
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        score = 0;
        scoreText.gameObject.SetActive(true);
        SetScore(highscoreText, highscore);
    }

    private void OnGameOver()
	{
        if (score > highscore)
            PlayerPrefs.SetInt("Highscore", score);

        scoreText.gameObject.SetActive(false);
        SetScore(gameOverScoreText, score);
	}

    private void OnUpdateScore()
    {
        score++;
        SetScore(scoreText, score);
    }

    void SetScore(TextMeshProUGUI textgui, int s)
	{
        textgui.SetText(s.ToString());
	}

	private void OnEnable()
	{
        BallController.updateScore += OnUpdateScore;
        BallController.gameOver += OnGameOver;
        PlayerController.restartGame += OnGameStart;
	}

	private void OnDisable()
	{
        BallController.updateScore -= OnUpdateScore;
        BallController.gameOver -= OnGameOver;
        PlayerController.restartGame -= OnGameStart;
    }
}
