using System;
using Interface;
using UnityEngine;

namespace Model
{
    public class Gem : MonoBehaviour, IPickable
    {
        public int score = 100;
        
        public Sprite sprite;
        public GameObject prefab;
        private void Awake()
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
        }
        public void OnPickedUp(PlayerController player)
        {
            ScoreManager.AddScore(score);
            Destroy(gameObject);
            // Tạo ra 1 ảnh ngôi sao sau khi thu thập Gem 
            GameObject star =  Instantiate(prefab, transform.position, Quaternion.identity);
            Destroy(star, 2f);
        }

   
    }
}