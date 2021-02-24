using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player2Controller : MonoBehaviour
{
    PlayerActions Input;
	public Slider staminaBar;

	public float maxStamina = 100f;
	private float currentStamina;

	private WaitForSeconds regenTick = new WaitForSeconds(0.02f);
	private Coroutine regen;

	public float rotationSpeed;
	float initRotationSpeed;
	float rotationValue;
	bool isShiftPressed;

	void Awake()
	{
		initRotationSpeed = rotationSpeed;
		Input = new PlayerActions();
		Input.Gameplay.Shift2.started += _ => onShiftPress();
		Input.Gameplay.Shift2.canceled += _ => onShiftRelease();
		InvokeRepeating("IncreaseSize", 1f, 1f);
		currentStamina = maxStamina;
		staminaBar.maxValue = maxStamina;
		staminaBar.value = currentStamina;
	}
    void OnEnable()
	{
		Input.Enable();
	}
	void onDisable()
	{
		Input.Disable();
	}
	void onShiftPress()
	{
		isShiftPressed = true;
	}
	void onShiftRelease()
	{
		isShiftPressed = false;
	}
    void FixedUpdate()
    {
		rotationValue = Input.Gameplay.Move2.ReadValue<float>();
		if (isShiftPressed)
		{
			if (currentStamina >= 1f && rotationValue != 0)
			{
				UseStamina(1f);
				rotationSpeed = initRotationSpeed * 2;
			}
			else
			{
				rotationSpeed = initRotationSpeed;
			}
		}
		else
		{
			rotationSpeed = initRotationSpeed;
		}
		float checkRotation = transform.rotation.eulerAngles.z + rotationValue;
		Debug.Log(checkRotation);
		if (checkRotation >= 15f && checkRotation <= 165f)
			transform.Rotate(Vector3.forward, rotationValue * rotationSpeed * Time.deltaTime);
	}

	public void UseStamina(float amount)
	{
		if(currentStamina - amount >= 0)
		{
			currentStamina -= amount;
			staminaBar.value = currentStamina;

			if (regen != null)
				StopCoroutine(regen);

			regen = StartCoroutine(RegenStamina());
		}
	}
	void IncreaseSize()
	{
		if (transform.localScale.x <= 0.51f)
			return;
		transform.localScale = new Vector3(transform.localScale.x - 0.01f, transform.localScale.y, transform.localScale.z);
	}
	private IEnumerator RegenStamina()
	{
		yield return new WaitForSeconds(1.2f);

		while(currentStamina < maxStamina)
		{
			currentStamina += maxStamina / 100;
			staminaBar.value = currentStamina;
			yield return regenTick;
		}
		regen = null;
	}

}
