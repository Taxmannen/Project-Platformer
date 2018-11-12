using UnityEngine;

public class SantaAIScript : MonoBehaviour
{
    Vector2 distance;
    public Transform player;
    public Transform weaponHold;
    public GameObject weapon;
    private Vector2 movementDirection;

    public float jumpRate = 2f;
    float timer;
    public float jumpHeight = 100;

    Rigidbody2D rb;

    void Start()
    {
        weapon.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        timer = jumpRate;
    }

    void FixedUpdate()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        if (distance < 10f)
        {
            weapon.SetActive(true);
            //rb.AddForce(Vector3.left * 5);
        }
        else weapon.SetActive(false);



        timer -= Time.deltaTime;
        if (timer < 0)
        {
            rb.gravityScale = -50;
            jump();
            timer = jumpRate;
        }
        else
        {
            rb.gravityScale = 1;
        }

    }



    void jump()
    {
        rb.AddForce(transform.up * jumpHeight);
    }
}
