using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float maxJumpHeight;

    Rigidbody2D rb;

    bool facingRight = true;
    bool isJumping;
    float jumpMaxTime;
    float jumpTime;
    float jumpPower;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
        if (Input.GetButtonDown("Cancel")) transform.position = new Vector2(0, 0); //För debug
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed;
        rb.velocity = new Vector2(x, rb.velocity.y);

        if      (x > 0 && !facingRight) facingRight = Flip(transform);
        else if (x < 0 && facingRight)  facingRight = Flip(transform);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            jumpMaxTime = Time.time + 0.65f;
            jumpTime = 0;
            jumpPower = 2.4f;
        }

        if (Input.GetButton("Jump") && Time.time < jumpMaxTime && isJumping)
        {
            jumpTime += Time.deltaTime;
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            if (jumpTime < 0.45)
            {
                if (jumpPower < maxJumpHeight) jumpPower *= 1.2f;
            }
            else jumpPower *= 0.8f;
        }
        if (Input.GetButtonUp("Jump")) jumpMaxTime = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground") isJumping = false;
    }

    public static bool Flip(Transform transform)
    {
        bool facingRight = false;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        if (theScale.x > 0) facingRight = true;
        transform.localScale = theScale;
        return facingRight;
    }
}
