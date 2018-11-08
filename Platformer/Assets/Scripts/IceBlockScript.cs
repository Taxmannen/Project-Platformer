using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class IceBlockScript : MonoBehaviour {

    public GameObject player;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            transform.Translate(0, 20 * Time.deltaTime, 0);
        }
        
            
            
    }



}
