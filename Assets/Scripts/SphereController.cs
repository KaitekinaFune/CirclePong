using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour
{
	int randomRotation;
	Rigidbody2D rb;
	public float ballSpeed;
	AudioSource pongSound;
	public float startDelay = 1.5f;
	public GameObject arrow;
    void Start()
    {
		pongSound = GetComponent<AudioSource>();
		rb = GetComponent<Rigidbody2D>();
		randomRotation = Random.Range(0, 361);
        transform.Rotate(transform.forward * randomRotation);
		StartCoroutine(WaitToStart(startDelay));
    }
	IEnumerator WaitToStart(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		rb.velocity = (transform.up * ballSpeed);
		arrow.SetActive(false);
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		ScoreScript score = collision.transform.GetComponent<ScoreScript>();
		if (score != null)
		{
			pongSound.Play();
			score.Score++;
		}
	}
}
