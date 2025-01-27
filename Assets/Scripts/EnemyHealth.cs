using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    int Startinghealth = 3;
    int CurrentHealth;
    void Start()
    {
        CurrentHealth = Startinghealth;
    }

    void Update()
    {
        if (CurrentHealth <= 0)
        { 
         GameObject.Destroy(gameObject);
        }

    }
    public void TakeDamage()
    {
        CurrentHealth -= 1;
    }
}
