using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public int fullHealth;
    public int currentHealth;
    
    
    public void AddHealth(int amount)
    {
        if (amount + currentHealth <= fullHealth) currentHealth += amount;
        else currentHealth = fullHealth;
    }

    public void RemoveHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;
    }

    void Update()
    {
        PlayerController pc = GetComponent<PlayerController>();
        float scale = (float)currentHealth/fullHealth;
        if (pc.facingRight) transform.localScale = new Vector3(scale, scale, scale);
        else                transform.localScale = new Vector3(-scale, scale, scale);
    }
}
