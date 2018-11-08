using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaSpawnScript : MonoBehaviour {

    Rigidbody2D rb;
    public Transform spawnPoint;
    public GameObject prefab;
    Sprite[] santaSprites;

	// Use this for initialization
	void Start () {

        Invoke("Spawn", 3f);
        
    }
	
	// Update is called once per frame
	void Update () {

	}

    void Spawn()
    {
        Instantiate(prefab, spawnPoint);
    }
}
