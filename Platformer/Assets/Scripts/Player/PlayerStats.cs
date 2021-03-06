﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour { 
    public int fullHealth;
    public int currentHealth;

    PlayerController pc;

    void Start()
    {
        pc = GetComponent<PlayerController>();
    }

    public void AddHealth(int amount)
    {
        if (amount + currentHealth <= fullHealth) currentHealth += amount;
        else currentHealth = fullHealth;
    }

    public void RemoveHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;
        if (currentHealth <= 0) SceneManager.LoadScene("Failure Scene");
    }

    void Update()
    {
        float scale = (float)currentHealth/fullHealth;
        if (scale > 0.1f)
        {
            if (pc.facingRight) transform.localScale = new Vector3(scale, scale, scale);
            else                transform.localScale = new Vector3(-scale, scale, scale);
        }   
    }
}
