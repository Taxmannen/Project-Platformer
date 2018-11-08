using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour {

    public Transform downPos;
    public Transform upPos;
    private Vector2 movementDirection;
    private Vector2 movementPerSecond;

    void Start () {
        movementDirection = new Vector2(0, 0.5f).normalized;
    }
	
	// Update is called once per frame
	void Update () {

        movementPerSecond = movementDirection * 1;

        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime),
        transform.position.y + (movementPerSecond.y * Time.deltaTime));

        if(transform.position.y >= upPos.position.y)
            movementDirection.y *= -1;
        if (transform.position.y <= downPos.position.y)
            movementDirection.y *= -1;
    }


    
}
