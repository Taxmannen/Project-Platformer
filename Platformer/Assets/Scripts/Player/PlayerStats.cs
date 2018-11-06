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
}
