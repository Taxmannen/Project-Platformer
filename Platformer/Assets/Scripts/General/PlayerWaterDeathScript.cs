using UnityEngine;

public class PlayerWaterDeathScript : MonoBehaviour {
    public Transform player;

    bool playerInside = false;
	
	void Update ()
    {
        if (playerInside)
        {
            PlayerStats playerStats = player.GetComponent<PlayerStats>();
            playerStats.RemoveHealth(playerStats.currentHealth);
        }       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        playerInside = true;
    }
}
