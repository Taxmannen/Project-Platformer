using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyStats : MonoBehaviour {
    public GameObject deathEffect;
    public AudioClip deathSound;
    [Range(0.05f, 1f)]
    public float volume;
    public int maxHealth;

    Transform parent;
    int currentHealth;

    void Start()
    {
        parent = GameObject.Find("Spawned Objects").transform;
        if (transform.parent == null || transform.parent.name != "Enemies") transform.SetParent(GameObject.Find("Enemies").transform);
        currentHealth = maxHealth;
    }

    public void RemoveHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;

        if (currentHealth <= 0)
        {
            if (gameObject.name.Contains("Santa")) SceneManager.LoadScene("Victory Scene");
            Destroy(gameObject);
            if (deathEffect != null)
            {
                GameObject current = Instantiate(deathEffect, transform.position, deathEffect.transform.rotation, parent);

                AudioSource audioSource = current.AddComponent<AudioSource>();
                if (audioSource != null)
                {
                    audioSource.clip = deathSound;
                    audioSource.volume = volume;
                    audioSource.Play();
                }
            }
        }
    }
}
