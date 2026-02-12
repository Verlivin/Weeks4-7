using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Despawn : MonoBehaviour
{
    public SpriteRenderer sp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (sp.bounds.Contains(mousePos))
        {
            Debug.Log("0");
            Destroy(gameObject);
        }
        
    }
    
}
