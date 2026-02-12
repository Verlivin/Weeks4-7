using UnityEngine;

public class Hammer : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			OnSpaceHolding();
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			OnSpaceReleased();
		}
	}
	void OnSpaceHolding()
	{
		Debug.Log("ooooo");
		Vector3 newRoatation = transform.eulerAngles;
		newRoatation.z = 0;
		transform.eulerAngles = newRoatation;
	}
	void OnSpaceReleased()
	{
		Debug.Log("aaaa");
		Vector3 newRoatation = transform.eulerAngles;
		newRoatation.z -= 60;
		transform.eulerAngles = newRoatation;
			
	}
}
