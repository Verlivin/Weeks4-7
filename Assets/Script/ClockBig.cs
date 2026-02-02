using UnityEngine;

public class ClockBig : MonoBehaviour
{

    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRoatation = transform.eulerAngles;
        t += Time.deltaTime;
        if (t > 1)
        {
            newRoatation.z += -30;
            t = 0;
        }
        transform.eulerAngles = newRoatation;
    }
}
