using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
    public Slider healthSlider;

    PlayerStats playerStats;
    float speed = 3f;

    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        healthSlider.maxValue = playerStats.fullHealth;
        healthSlider.value    = playerStats.fullHealth;
    }

    void Update()
    {
        SetSliderValues();
    }

    private void SetSliderValues()
    {
        healthSlider.maxValue = playerStats.fullHealth;
        float healthDiff = healthSlider.value - playerStats.currentHealth;

        if (healthSlider.value > playerStats.currentHealth)
        {
            if (healthDiff < speed) speed = healthDiff;
            healthSlider.value -= speed;
        }
        else if (healthSlider.value < playerStats.currentHealth)
        {
            if (healthDiff > speed) speed = healthDiff;
            healthSlider.value += speed;
        }
        //Debug.Log("Health: " + ps.currentHealth + " " + "Slider Value "  + healthSlider.value);
    }
}
