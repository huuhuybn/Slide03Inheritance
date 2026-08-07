using System;
using UnityEngine;

namespace Component
{
    public class TakeDamageDetector : MonoBehaviour
    {

        public int dam = 20;
        
        // Hàm xảy ra khi có va chạm lần đầu tiên ,
        // thông tin đối tượng va chạm chứa trong biến other
        private void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log(other.collider.name);
            // nếu có interface, thì phải viết if kiểm tra xem
            // là va chạm với đối  tượng nào để xử lý tình huống 
            IDamageable target = other.gameObject.
                GetComponent<IDamageable>();
            if (target != null)
            {
                target.TakeDamage(dam);
            }
        }
    }
}