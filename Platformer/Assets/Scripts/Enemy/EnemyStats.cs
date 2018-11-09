using UnityEngine;

public class EnemyStats : MonoBehaviour {
    public GameObject soundObject;
    public AudioClip deathSound;
    [Range(0.05f, 1f)]
    public float volume;
    public int maxHealth;

    Transform parent;
    int currentHealth;

    void Start()
    {
        parent = GameObject.Find("Spawned Objects").transform;
        currentHealth = maxHealth;
        if (transform.parent == null || transform.parent.name != "Enemies") transform.SetParent(GameObject.Find("Enemies").transform);
    }

    void Update ()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            if (soundObject != null)
            {
                GameObject current = Instantiate(soundObject, transform.position, transform.rotation, parent);
                AudioSource audioSource = current.GetComponent<AudioSource>();
                if (audioSource != null)
                {
                    audioSource.clip = deathSound;
                    audioSource.volume = volume;
                    audioSource.Play();
                }
            }
        }
	}

    public void RemoveHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;
    }
}
