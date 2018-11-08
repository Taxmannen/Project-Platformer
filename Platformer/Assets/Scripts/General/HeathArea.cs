using UnityEngine;

public class HeathArea : MonoBehaviour {
    public float damageRate;

    PlayerStats playerStats;
    float meltTimer;

    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        meltTimer = damageRate;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        meltTimer -= Time.deltaTime;
        if (other.tag == "Player" && meltTimer <= 0)
        {
            playerStats.RemoveHealth(1);
            meltTimer = damageRate;
            //Start Particle
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Stop Particle 
        }
    }
}
