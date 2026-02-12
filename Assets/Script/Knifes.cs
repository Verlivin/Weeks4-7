using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Knifes : MonoBehaviour
{
    public GameObject KnifePrefab;
    public List<GameObject> knifes;
    public List<Transform> spawnPos;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            knifes.Add(KnifePrefab);
            Instantiate(KnifePrefab, spawnPos[i].position, spawnPos[i].rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        knifes.Remove(KnifePrefab);
        Destroy(KnifePrefab);
    }
}
