using UnityEngine;
using UnityEngine.UI;

public class Charge : MonoBehaviour
{
	public Slider slider;
	public Slider score;
	private float chargeDir = 1;
	private bool raise = false;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			OnSpacePressed();
		}
		if (Input.GetKey(KeyCode.Space))
		{
			OnSpaceHolding();
		}


		if (Input.GetKeyUp(KeyCode.Space))
		{
			OnSpaceReleased();
			raise = true;
		}
		if(raise == true)
		{
			score.value += 1000 * Time.deltaTime;
			if (score.value >= slider.value)
			{
				raise = false;
			}

		}
	}
	void OnSpacePressed()
	{
		Debug.Log("uuuu");
		slider.value = 0;
		score.value = 0;
	}
	void OnSpaceHolding()
	{
		Debug.Log("ooooo");
		if (slider.value <= 0 || slider.value >= 1000)
		{
			chargeDir *= -1;
		}
		slider.value += chargeDir;

	}

	void OnSpaceReleased()
	{
		Debug.Log("aaaa");
		
	}
}
