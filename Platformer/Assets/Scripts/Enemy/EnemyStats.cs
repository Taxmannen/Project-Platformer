using UnityEngine;

public class EnemyStats : MonoBehaviour {
    public GameObject soundObject;
    public AudioClip deathSound;
    public int maxHealth;

    Transform parent;
    int currentHealth;

    void Start()
    {
        parent = GameObject.Find("Spawned Objects").transform;
        currentHealth = maxHealth;
    }

    void Update ()
    {
        if (currentHealth <= 0) Destroy(gameObject);
	}

    void OnDestroy()
    {
        GameObject current = Instantiate(soundObject, transform.position, transform.rotation, parent);
        AudioSource audioSource = current.GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.clip = deathSound;
            audioSource.Play();
        }
    }

    public void RemoveHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;
    }
}
