using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float latestDirectionChangeTime;
    public float characterVelocity = 1f;
    private Vector2 movementDirection;
    private Vector2 movementPerSecond;

    public bool hitByPlayer;

    bool facingRight;

    void Start()
    {
        movementDirection = new Vector2(-1, 0).normalized;
    }

    void Update()
    {
        movementPerSecond = movementDirection * characterVelocity;
        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime),
        transform.position.y + (movementPerSecond.y * Time.deltaTime));

        if      (movementDirection.x < 0) facingRight = false;
        else if (movementDirection.x > 0) facingRight = true;

        if (facingRight)  transform.localRotation = Quaternion.Euler(0, 180, 0);
        if (!facingRight) transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "EdgeCollider")
        {
            movementDirection.x *= -1;
        }
    }
}

