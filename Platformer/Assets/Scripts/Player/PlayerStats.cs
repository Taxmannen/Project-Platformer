using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour { 
    public int fullHealth;
    public int currentHealth;

    PlayerController pc;

    private void Start()
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
    }

    void Update()
    {
        float scale = (float)currentHealth/fullHealth;
        if (scale > 0.05f)
        {
            if (pc.facingRight) transform.localScale = new Vector3(scale, scale, scale);
            else                transform.localScale = new Vector3(-scale, scale, scale);
        }   

        if (currentHealth <= 0) SceneManager.LoadScene("Main");
        //if (currentHealth <= 0) SceneManager.LoadScene("Start Menu Scene");
    }
}
