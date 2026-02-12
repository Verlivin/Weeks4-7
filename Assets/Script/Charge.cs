using UnityEngine;

public class Charge : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public Color col;
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
		spriteRenderer.color = Color.white;

	}

	void OnSpaceReleased()
	{
		Debug.Log("aaaa");
		spriteRenderer.color = Color.red;

	}
}
