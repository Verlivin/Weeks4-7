using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class Chargebar : MonoBehaviour
{
    public Slider slider;
	public Image image;
	public Image image2;//just found out there are two image need to be filled, background and fill of the slider
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (slider.value <= 333)//simple color change
		{
			image.color = Color.green;
			image2.color = Color.green;
		}
		else if (slider.value <= 666)
		{
			image.color = Color.yellow;
			image2.color = Color.yellow;
		}
		else
		{
			image.color = Color.red;
			image2.color = Color.red;
		}
	}
}
