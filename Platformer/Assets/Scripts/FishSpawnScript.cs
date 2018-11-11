using UnityEngine;

public class FishSpawnScript : MonoBehaviour {
    public GameObject fish;
    public Transform[] spawnPoints;

	void Start ()
    {
        InvokeRepeating("Spawn", 3f, 2f);
    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(fish, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
