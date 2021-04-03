using System.Collections;
using UnityEngine;

public class BallController : MonoBehaviour
{
	public static event System.Action updateScore;
	public static event System.Action gameOver;

	Coroutine delayStart;

	public AudioSource pongSound;

	Rigidbody2D rb;
	public float ballSpeed;
	public float startDelay = 1.5f;
	public GameObject arrow;

    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		OnGameStart();
    }

	void OnGameStart()
	{
		rb.velocity = Vector2.zero;
		transform.position = Vector3.zero;

		if (delayStart != null)
			StopCoroutine(delayStart);

		arrow.SetActive(true);

		GetRandomDirection();
		GetRandomSpeed();

		delayStart = StartCoroutine(WaitToStart(startDelay));
	}

	void GetRandomSpeed()
	{
		ballSpeed *= Random.Range(0.9f, 1.1f);
	}

	void GetRandomDirection()
	{
		transform.Rotate(transform.forward * Random.Range(0, 361));
	}

	IEnumerator WaitToStart(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		rb.velocity = (transform.up * ballSpeed);
		arrow.SetActive(false);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			updateScore?.Invoke();
			pongSound.Play();
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		gameOver?.Invoke();
	}

	private void OnEnable()
	{
		PlayerController.restartGame += OnGameStart;
	}

	private void OnDisable()
	{
		PlayerController.restartGame -= OnGameStart;
	}

}
