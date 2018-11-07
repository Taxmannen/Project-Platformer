using UnityEngine;

public class Snowball : MonoBehaviour {
    public GameObject effect;
    public int damage;

    Transform parent;
    GameObject player;
    PlayerController playerController;
    PlayerStats playerStats;
    Rigidbody2D rb;

    float scale = 1;
    float timer;
    float speed;
    bool taken;

	void Start ()
    {
        player = GameObject.Find("Player");
        parent = GameObject.Find("Spawned Objects").transform;
        playerController = player.GetComponent<PlayerController>();
        playerStats      = player.GetComponent<PlayerStats>();
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

        CalculateSpeed();
        rb = GetComponent<Rigidbody2D>();
        if (playerController.facingRight) rb.AddForce(new Vector2(speed, 3),  ForceMode2D.Impulse);
        else                              rb.AddForce(new Vector2(-speed, 3), ForceMode2D.Impulse);
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
        else if (other.tag == "Enemy" && !taken)
        {
            EnemyStats enemyStats = other.GetComponent<EnemyStats>();
            enemyStats.RemoveHealth(damage);
            Destroy(gameObject);
            Instantiate(effect, transform.position, effect.transform.rotation, parent);
            taken = true;
        }

        else if (other.tag == "Ground")
        {
            Transform currentEffect = Instantiate(effect, transform.position, effect.transform.rotation, parent).transform;
            currentEffect.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }

    void CalculateSpeed()
    {
        float velocityX = player.GetComponent<Rigidbody2D>().velocity.x;
        speed = Mathf.Abs(velocityX/2) + 5;
    }
}