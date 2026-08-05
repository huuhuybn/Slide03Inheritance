using Component;
using UnityEngine;

namespace Model
{
    // ép buộc dùng kèm Healthy Component
    [RequireComponent(typeof(Healthy))]
    [RequireComponent(typeof(EnemyVisual))]
    public class Orc : Enemy
    {
      
        Healthy _healthy;
        private EnemyVisual _visual;
        void Awake()
        {
            _visual = GetComponent<EnemyVisual>();
            _healthy = GetComponent<Healthy>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
            FlipSprite(-1);
            _visual.ShowIdle();
        }

        void Update()
        {
            // Hàm ở lớp cha 
            Move();
        }
        protected override void Attack()
        {
            base.Attack();
            _visual.ShowAttack();
        }

        protected override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            _healthy.TakeDamage(damage);
        }
    }
}