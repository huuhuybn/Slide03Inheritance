using Component;
using Interface;
using UnityEngine;

namespace Model
{
    // ép buộc dùng kèm Healthy Component
    [RequireComponent(typeof(Healthy))]
    [RequireComponent(typeof(EnemyVisual))]
    public class Orc : Enemy, IAttackable, ITransform, IDamageable
    {
        Healthy _healthy;
        private EnemyVisual _visual;
        void Awake()
        {
            _visual = GetComponent<EnemyVisual>();
            _healthy = GetComponent<Healthy>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
            FlipSprite(-1);
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
        
        public void Attack(int damage)
        {
          Debug.Log(damage);
        }

        public void Transform()
        {
          Debug.Log("Transform");
          transform.localScale *= 2;
        }

        public bool TakeDamage(int damage)
        {
            return _healthy.TakeDamage(damage);
        }
    }
}