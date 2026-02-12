using UnityEngine;
using UnityEngine.UI;

public class Charge : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public Color col;
	public Slider slider;
	private float chargeDir = 1;
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
		}
	}
	void OnSpacePressed()
	{
		Debug.Log("uuuu");
		slider.value = 0;
	}
	void OnSpaceHolding()
	{
		Debug.Log("ooooo");
		if (slider.value <= 0 || slider.value >=1000)
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
