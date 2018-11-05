using UnityEngine;

public class Snowball : MonoBehaviour {
    PlayerController player;
    Rigidbody2D rb;

    float scale = 1;
    float timer;

	void Start ()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

        rb = GetComponent<Rigidbody2D>();
        if (player.facingRight) rb.AddForce(new Vector2(3, 3),  ForceMode2D.Impulse);
        else                    rb.AddForce(new Vector2(-3, 3), ForceMode2D.Impulse);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            if (scale > 0) scale -= 0.00025f;
            transform.localScale = new Vector3(scale, scale, scale);
        }
        if (scale <= 0) Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log((int)transform.localScale.x * 100);
        }
    }
}
