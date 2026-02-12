using UnityEngine;
using UnityEngine.UI;

public class Charge : MonoBehaviour
{
	public Slider slider;
	public Slider score;
	private float chargeDir = 1;
	private bool raise = false;
	public AudioSource audioSource;
	public AudioClip hit;
	public AudioClip win;
	public AudioClip lose;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space)) //when press space, use for reset
		{
			OnSpacePressed();
		}
		if (Input.GetKey(KeyCode.Space)) //when hold space, use for charge
		{
			OnSpaceHolding();
		}


		if (Input.GetKeyUp(KeyCode.Space)) //when releast space, use for score
		{
			OnSpaceReleased();
			raise = true; //raise the score thing
		}
		if(raise == true)
		{
			score.value += 1000 * Time.deltaTime; //1000 is the speed of raising, just feel no need of add another float for this
			if (score.value >= slider.value)
			{
				if(score.value < 980)
				{
					audioSource.PlayOneShot(lose);
				}
				else
				{
					audioSource.PlayOneShot(win);
				}
					raise = false;
			}

		}
	}
	void OnSpacePressed()
	{
		Debug.Log("uuuu"); //reset
		slider.value = 0;
		score.value = 0;
		audioSource.Play();
	}
	void OnSpaceHolding()
	{
		Debug.Log("ooooo"); //charge, go back and front
		if (slider.value <= 0 || slider.value >= 1000)
		{
			chargeDir *= -1;
		}
		slider.value += chargeDir;

	}

	void OnSpaceReleased()
	{
		Debug.Log("aaaa"); //just a debug
		audioSource.Stop();
		audioSource.PlayOneShot(hit);
		
	}
}
