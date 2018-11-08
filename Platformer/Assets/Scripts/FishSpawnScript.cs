using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawnScript : MonoBehaviour {

    public GameObject fish;
    public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", 3f, 2f);
    }
	
	// Update is called once per frame
	void Update () {

        

	}


    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(fish, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
