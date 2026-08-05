using UnityEngine;

namespace Model
{
    public class Soldier : Enemy
    {
        public Sprite idleSprite;
        public Sprite attackSprite;
        public Sprite defenceSprite;

        void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _spriteRenderer.sprite = idleSprite;
        }
        void Update()
        {
            // Hàm ở lớp cha 
            Move();
        }

        protected override void Move()
        {
            //base.Move();
            transform.Translate(
                Vector2.right * moveSpeed * Time.deltaTime);
        }
        protected override void Attack()
        {
            base.Attack();
            _spriteRenderer.sprite = attackSprite;
        }

        protected override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            _spriteRenderer.sprite = defenceSprite;
        }
        
    }
}