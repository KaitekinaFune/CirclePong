using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
	public int P1Score;
	public int P2Score;
	public bool leftSide;

	public TextMeshProUGUI P1ScoreText;
	public TextMeshProUGUI P2ScoreText;
	public TextMeshProUGUI Winner;


	public void SetScore()
	{
		P1ScoreText.SetText("P1:\n" + P1Score);
		P2ScoreText.SetText("P2:\n" + P2Score);

		switch (leftSide)
		{
			case true:
				Winner.SetText("Winner:\nP2!");
				break;
			case false:
				Winner.SetText("Winner:\nP1!");
				break;
		}
	}
}
