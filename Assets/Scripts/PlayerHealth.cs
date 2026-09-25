using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health")]
    public int maxHealth = 100;
    int currentHealth;

    GameManager gameManager;

    void Start()
    {
        currentHealth = maxHealth;
        gameManager = FindObjectOfType<GameManager>();
        gameManager.UpdateHealthDisplay(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        gameManager.UpdateHealthDisplay(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Du bist tot!");
        Time.timeScale = 0f; // Spiel pausieren
    }
}
