using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	public static event System.Action restartGame;

	public float rotationSpeed;
	private float rotationDirection;

	public float playerSizeThreshold = 0.6f;

	bool isGameOver;

	PlayerActions input;

	private void Awake()
	{
		input = new PlayerActions();

		OnGameStart();
	}

	void OnGameStart()
	{
		isGameOver = false;

		transform.rotation = Quaternion.Euler(Vector3.zero);
		transform.localScale = Vector3.one;
	}

	private void OnMove(InputAction.CallbackContext ctx)
	{
		rotationDirection = ctx.ReadValue<float>();
	}

	private void Update()
	{
		if (!isGameOver && rotationSpeed != 0)
		{
			transform.Rotate(Vector3.forward * rotationSpeed * rotationDirection * Time.deltaTime);
		}

		if (transform.localScale.x > playerSizeThreshold)
		{
			transform.localScale -= (Vector3.right/100 * Time.deltaTime);
		}
	}

	private void OnRestart(InputAction.CallbackContext ctx)
	{
		if (isGameOver)
		{
			restartGame?.Invoke();
			OnGameStart();
		}
	}

	private void OnEnable()
	{
		input.Gameplay.Enable();
		input.Gameplay.Move.performed += OnMove;
		input.Gameplay.Restart.performed += OnRestart;

		BallController.gameOver += OnGameOver;
	}

	private void OnDisable()
	{
		input.Gameplay.Disable();
		input.Gameplay.Move.performed -= OnMove;
		input.Gameplay.Restart.performed -= OnRestart;

		BallController.gameOver -= OnGameOver;
	}

	void OnGameOver()
	{
		isGameOver = true;
	}
}
