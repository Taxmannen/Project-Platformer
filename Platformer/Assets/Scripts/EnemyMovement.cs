using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{



    private float latestDirectionChangeTime;
    private float characterVelocity = 1f;
    private Vector2 movementDirection;
    private Vector2 movementPerSecond;

    public bool hitByPlayer;

    Rigidbody2D rb;

    bool facingRight;

    private GameObject player;

    void Awake()
    {
        player = GameObject.Find("Player");
    }

    void Start()
    {
        movementDirection = new Vector2(-1, 0).normalized;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //if the changeTime was reached, calculate a new movement vector

        movementPerSecond = movementDirection * characterVelocity;
        //move enemy: 
        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime),
        transform.position.y + (movementPerSecond.y * Time.deltaTime));

        if (movementDirection.x < 0)
            facingRight = false;
        else if (movementDirection.x > 0)
            facingRight = true;

        if (facingRight)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        if (!facingRight)
            transform.localRotation = Quaternion.Euler(0, 0, 0);

        //Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "EdgeCollider")
        {
            movementDirection.x *= -1;
        }


    }



}

