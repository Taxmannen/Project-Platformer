using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameHurtPlayerScript : MonoBehaviour {

    public Transform player;
    bool playerInside = false;

    public float damageRate = 2f;
    float timer;

    // Use this for initialization
    void Start () {

        timer = damageRate;
    }
	
	// Update is called once per frame
	void Update () {
		if(playerInside)
        {

            
            PlayerStats playerStats = player.GetComponent<PlayerStats>();
           
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                playerStats.RemoveHealth(30);
                timer = damageRate;
                
            }
        }
    
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            playerInside = true;
            Debug.Log("Hit");
        }
    }
}
