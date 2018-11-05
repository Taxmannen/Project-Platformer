using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed;
        rb.velocity = new Vector2(x, rb.velocity.y);
    }
}
