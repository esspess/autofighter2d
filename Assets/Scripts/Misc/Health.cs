using UnityEngine;


public class Health
{
    private float currentHealth = 100;

    public float GetHealth()
    {
        return currentHealth;
    }
    public void SetHealth(float health)
    {
        currentHealth = health;
    }
    public void IncreaseBy(float percentage)
    {
        currentHealth += currentHealth * percentage;
    }
    public void DecreaseBy(float percentage)
    {
        currentHealth -= currentHealth * percentage;
    }

    public void TryTakeDamage(float amount)
    {
        float healthAfterDamage = currentHealth - amount;
        if (healthAfterDamage > 0)
        {
            currentHealth -= amount;
            Debug.Log($"The amount : {amount}-- after health {currentHealth}");
        }
        else
        {
            // signal dead
        }
    }
}