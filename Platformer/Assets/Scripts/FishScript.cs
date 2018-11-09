using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour {

    public float speed = 5;
    Vector2 movementDirection;
    Vector2 movementPerSecond;
    

    // Use this for initialization
    void Start () {
        movementDirection = new Vector2(1, 0).normalized;
    }
	
	// Update is called once per frame
	void Update () {
        movementPerSecond = movementDirection * speed;
        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime), transform.position.y);

        Object.Destroy(gameObject, 50.0f);
    }
}
