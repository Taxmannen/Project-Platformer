using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Slider healthSlider;

    PlayerStats ps;

    void Start()
    {
        ps = GameObject.Find("Player").GetComponent<PlayerStats>();
        healthSlider.maxValue = ps.fullHealth;
        healthSlider.value = ps.fullHealth;
    }

    void Update()
    {
        SetSliderValues();
    }

    private void SetSliderValues()
    {
        healthSlider.maxValue = ps.fullHealth;

        float speed = 3f;
        float healthDiff = healthSlider.value - ps.currentHealth;

        if (healthSlider.value > ps.currentHealth)
        {
            if (healthDiff < speed) speed = healthDiff;
            healthSlider.value -= speed;
        }
        else if (healthSlider.value < ps.currentHealth)
        {
            if (healthDiff > speed) speed = healthDiff;
            healthSlider.value += speed;
        }

        //Debug.Log("Health: " + currentHealth + " " + "Slider Value "  + healthSlider.value);
    }
}
