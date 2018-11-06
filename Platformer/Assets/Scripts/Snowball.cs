using UnityEngine;

public class Snowball : MonoBehaviour {
    GameObject player;
    PlayerController playerController;
    PlayerStats playerStats;
    Rigidbody2D rb;

    float scale = 1;
    float timer;
    bool taken;

	void Start ()
    {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
        playerStats      = player.GetComponent<PlayerStats>();
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

        rb = GetComponent<Rigidbody2D>();
        if (playerController.facingRight) rb.AddForce(new Vector2(3, 3),  ForceMode2D.Impulse);
        else                              rb.AddForce(new Vector2(-3, 3), ForceMode2D.Impulse);
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
        if (other.tag == "Player" && timer >= 0.5f && !taken)
        {
            int healthAmout = (int)(scale * 10);
            playerStats.AddHealth(healthAmout);
            Destroy(gameObject);
            taken = true;
        }
    }
}
