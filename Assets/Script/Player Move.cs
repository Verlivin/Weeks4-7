using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 move;
    private Animator ani;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
		move.y = Input.GetAxis("Vertical");

        move = move.normalized;

        ani.SetFloat("Hori",move.x);
		ani.SetFloat("Vert", move.y);
		ani.SetFloat("speed", move.magnitude);

	}
    private void FixedUpdate()
    {
        rb.linearVelocity = move * speed;
    }
}
