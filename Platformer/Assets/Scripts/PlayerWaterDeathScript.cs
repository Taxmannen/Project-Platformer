using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWaterDeathScript : MonoBehaviour {

    bool playerInside = false;
    public Transform player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
