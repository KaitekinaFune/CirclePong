using UnityEngine;
using TMPro;

public class GameOver1P : MonoBehaviour
{
	public Transform GameOverScreen;
	public ScoreScript p1;
	public TextMeshProUGUI ScoreText;
    void OnCollisionEnter(Collision collision)
	{
		SphereController sphere = collision.transform.GetComponent<SphereController>();
		if (sphere != null)
		{
			ScoreText.SetText(p1.Score.ToString());
			GameOverScreen.gameObject.SetActive(true);
			Destroy(sphere);
		}
	}
}