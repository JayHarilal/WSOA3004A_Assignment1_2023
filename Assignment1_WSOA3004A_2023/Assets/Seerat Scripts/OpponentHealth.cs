using UnityEngine;
using UnityEngine.UI;

public class OpponentHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Slider healthSlider;

    void Start()
    {
        // Initialize opponent's health at maximum value
        currentHealth = maxHealth;

        // Update the health slider with the initial health value
        UpdateHealthSlider();
    }

    public void TakeDamage(int damageAmount)
    {
        // Reduce opponent's health by the damage amount
        currentHealth -= damageAmount;

        // Check if health goes below zero
        if (currentHealth <= 0)
        {
            // Opponent is defeated or victory logic goes here.
            currentHealth = 0;
            Debug.Log("Opponent is defeated!");
        }

        // Update the health slider
        UpdateHealthSlider();
    }

    void UpdateHealthSlider()
    {
        // Update the slider value based on current health and maximum health
        healthSlider.value = (float)currentHealth / maxHealth;
    }
}
