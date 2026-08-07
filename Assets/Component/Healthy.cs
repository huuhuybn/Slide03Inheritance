using UnityEngine;


public class Healthy : MonoBehaviour, IDamageable
{
    [Header("Thông số máu")]
    public int maxHealth = 100;
    public int currentHealth;
    bool isDead => currentHealth <= 0;

    void Start()
    {
        currentHealth = maxHealth;
    }
    

    public void Heal(int amount)
    {
        if (isDead)
        {
            return;
        }
        currentHealth += amount;
    }

    public bool TakeDamage(int damage)
    {
        if (isDead)
        {
            return true;
        }
        currentHealth -= damage;
        return isDead;
    }
}