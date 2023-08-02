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
    }

    private void Update()
    {

        if (currentHealth >= maxHealth)
            currentHealth = maxHealth;
        // Update the slider value based on current health and maximum health
        healthSlider.value = currentHealth;
    }
}
