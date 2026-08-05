using System;
using System.Net.Http.Headers;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Tốc độ di chuyển 
    protected float moveSpeed = 2f;
    // máu tối đa 
    protected int maxHealth = 5;
    // Quy định hình ảnh cho nhân vật 
    protected SpriteRenderer _spriteRenderer;
    // máu hiện tại 
    protected int currentHealth;
    
    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }
    protected virtual void Move()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
    protected virtual void Attack()
    {
        Debug.Log("Attack");
    }
    protected virtual void Die()
    {
        Destroy(gameObject);
    }
    protected virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        // Bổ sung thêm hiệu ứng khi bị  tấn công 
    }
    protected void FlipSprite(float direction)
    {
        if (direction != 0)
        {
            _spriteRenderer.flipX = direction < 0;
        }
    }
    
    
}
