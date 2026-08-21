using System;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class BulletPool : MonoBehaviour
    {
        // Ap dung Single Ton
        public static BulletPool instance;
        
        [Header("Bullet Prefab")]
        public GameObject bulletPrefab;
        public int poolSize = 20;
        // tao ra 1 hàng đợi 
        Queue<GameObject> bulletPool = new Queue<GameObject>();

        private void Awake()
        {
            instance = this;
            for (int i = 0; i < poolSize; i++)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform);
                bullet.SetActive(false); // ẩn viên đạn khi chưa dùng 
                bulletPool.Enqueue(bullet);
            }
        }

        public GameObject GetBullet(Vector3 position, Quaternion rotation)
        {
            if (bulletPool.Count > 0)
            {
                GameObject bullet = bulletPool.Dequeue();
                bullet.transform.position = position;
                bullet.transform.rotation = rotation;
                bullet.SetActive(true);
                return bullet;
            }
            else
            {
                Debug.LogWarning("Pool is empty");
                return null;
            }
    }
     public void ReturnBullet(GameObject bullet){
        bullet.SetActive(false);
        bulletPool.Enqueue(bullet);}   
    }
}