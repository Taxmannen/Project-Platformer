﻿using UnityEngine;

public class EnemyStats : MonoBehaviour {
    public GameObject soundObject;
    public AudioClip deathSound;
    public int maxHealth;

    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;    
    }

    void Update ()
    {
        if (currentHealth <= 0) Destroy(gameObject);
	}

    void OnDestroy()
    {
        GameObject current = Instantiate(soundObject, transform.position, transform.rotation, GameObject.Find("Spawned Objects").transform);
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
