using UnityEngine;

public class HeathArea : MonoBehaviour {
    public float damageRate;

    ParticleSystem meltParticle;
    PlayerStats playerStats;
    float meltTimer;

    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        meltParticle = playerStats.GetComponentInChildren<ParticleSystem>();
        meltParticle.Stop();
        meltTimer = damageRate;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        meltTimer -= Time.deltaTime;
        if (other.tag == "Player" && meltTimer <= 0)
        {
            playerStats.RemoveHealth(1);
            meltTimer = damageRate;
            meltParticle.Play();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            meltParticle.Stop();
        }
    }
}
