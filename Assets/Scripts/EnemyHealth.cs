using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    int Startinghealth = 3;
    int currentHealth;
    void Start()
    {
        currentHealth = Startinghealth;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            GameObject.Destroy(gameObject);
        }

    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
