using UnityEngine;

public class EnemyDamage : MonoBehaviour {
    public int damage;
    public float damageRate;

    PlayerStats playerStats;
    float timer;

    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    void Update ()
    {
        timer -= Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (timer <= 0)
            {
                playerStats.RemoveHealth(damage);
                timer = damageRate;
            }
        }
    }
}
