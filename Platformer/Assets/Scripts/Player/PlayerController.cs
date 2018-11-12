using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    [HideInInspector] public bool facingRight = true;
    public float speed;
    public float maxJumpHeight;
    public float x;

    Rigidbody2D rb;
    AudioSource audioSource;
    bool isJumping;
    float jumpMaxTime;
    float jumpTime;
    float jumpPower;
    float sprint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel")) SceneManager.LoadScene("Main");
        Move();
        Jump();
    }

    void Move()
    {
        if (Input.GetButton("Sprint") && sprint <= 5) sprint += 0.2f;
        else                                          sprint = 0;

        x = Input.GetAxisRaw("Horizontal") * (speed + sprint);
        rb.velocity = new Vector2(x, rb.velocity.y);

        if (x != 0 && !audioSource.isPlaying) audioSource.Play();

        if      (x > 0 && !facingRight) facingRight = Flip(transform);
        else if (x < 0 && facingRight)  facingRight = Flip(transform);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            jumpMaxTime = Time.time + 0.5f;
            jumpTime = 0;
            jumpPower = 2.4f;
        }

        if (Input.GetButton("Jump") && Time.time < jumpMaxTime && isJumping)
        {
            jumpTime += Time.deltaTime;
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            if (jumpTime < 0.4)
            {
                if (jumpPower < maxJumpHeight) jumpPower *= 1.5f;
            }
            else jumpPower *= 0.8f;
        }
        if (Input.GetButtonUp("Jump")) jumpMaxTime = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground") isJumping = false;
    }

    bool Flip(Transform transform)
    {
        bool facingRight = false;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        if (theScale.x > 0) facingRight = true;
        transform.localScale = theScale;
        return facingRight;
    }
}
