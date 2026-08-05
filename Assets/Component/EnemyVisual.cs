using System;
using UnityEngine;

namespace Component
{
    public class EnemyVisual : MonoBehaviour
    {
        public Sprite idleSprite;
        public Sprite attackSprite;
        SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }
        
        public void ShowIdle()
        {
            _spriteRenderer.sprite = idleSprite;
        }

        public void ShowAttack()
        {
            _spriteRenderer.sprite = attackSprite;
        }

        public void Flip(float direction)
        {
            if (direction == 0)
            {
                return;
            }   
            _spriteRenderer.flipX = direction < 1;
        }
    }
}