using UnityEngine;

public class EnemyStats : MonoBehaviour {
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
        //Do stuff   
    }

    public void RemoveHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;
    }
}
