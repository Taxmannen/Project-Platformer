using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{

    public Transform startPos;
    public Transform endPos;
    private Vector2 movementDirection;
    private Vector2 movementPerSecond;
    public Transform player;

    bool playerInside = false;

    public float speed;


    void Start()
    {
        movementDirection = new Vector2(0.1f, 0).normalized;
    }

    // Update is called once per frame
    void Update()
    {

        if (playerInside)
        {
            if (player.GetComponent<PlayerController>().facingRight == true && transform.position.x <= endPos.position.x)
                transform.Translate(movementDirection * Time.deltaTime * speed);

            else if (player.GetComponent<PlayerController>().facingRight != true && transform.position.x >= startPos.position.x)
                transform.Translate(movementDirection *-1 * Time.deltaTime * speed);
        }

        

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        player.transform.parent = transform;
        //if(col.tag == "Player")
        playerInside = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
       playerInside = false;
    }
}

