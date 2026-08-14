using System;
using UnityEngine;
using UnityEngine.UI;


public class Healthy : MonoBehaviour, IDamageable
{
    [Header("Thông số máu")]
    public int maxHealth = 100;
    public int currentHealth;
    // tương tự delegate 
    public static event Action OnPlayerDie;

    void Die()
    {
        Debug.Log("Die");
        OnPlayerDie?.Invoke();
    }

    bool isDead => currentHealth <= 0;

    public bool TakeDamage(int damage)
    {
        if (isDead)
        {
            return true;
        }

        currentHealth -= damage;
        if (isDead)
        {
            Die();
        }
        return isDead;
    }
    
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
 
}