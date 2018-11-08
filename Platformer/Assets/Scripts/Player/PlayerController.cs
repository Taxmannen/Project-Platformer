﻿using UnityEngine;

public class PlayerController : MonoBehaviour {
    [HideInInspector] public bool facingRight = true;
    public float speed;
    public float maxJumpHeight;

    Rigidbody2D rb;
    AudioSource audioSource;
    bool isJumping;
    float jumpMaxTime;
    float jumpTime;
    float jumpPower;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel")) transform.position = new Vector2(0, 0); //För debug
        Move();
        Jump();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed;
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
