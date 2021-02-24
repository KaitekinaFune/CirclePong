using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour
{
	int randomRotation;
	Rigidbody rb;
	public float ballSpeed;
	AudioSource pongSound;
	public float startDelay = 1.5f;
	public GameObject arrow;
    void Start()
    {
		pongSound = GetComponent<AudioSource>();
		rb = GetComponent<Rigidbody>();
		randomRotation = Random.Range(0, 361);
        transform.Rotate(transform.forward * randomRotation);

		StartCoroutine(WaitToStart(startDelay));
    }
	IEnumerator WaitToStart(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		rb.velocity = (transform.up * ballSpeed);
		Destroy(arrow);
	}
	void OnCollisionEnter(Collision collision)
	{
		ScoreScript score = collision.transform.GetComponent<ScoreScript>();
		if (score != null)
		{
			pongSound.Play();
			score.Score++;
		}
	}
}
