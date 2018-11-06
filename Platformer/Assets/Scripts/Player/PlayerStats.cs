using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public float fullHealth;
    public float currentHealth;
    
    public void AddHealth(int amount)
    {
        if (amount + currentHealth <= fullHealth) currentHealth += amount;
        else currentHealth = fullHealth;
    }
}
