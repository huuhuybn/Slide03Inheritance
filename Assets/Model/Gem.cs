using System;
using Interface;
using UnityEngine;

namespace Model
{
    public class Gem : MonoBehaviour, IPickable
    {
        public int score = 100;
        
        public Sprite sprite;
        
        private void Awake()
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
        }
        public void OnPickedUp(PlayerController player)
        {
            ScoreManager.AddScore(score);
            Destroy(gameObject);
        }
    }
}