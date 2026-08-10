using System;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    
    public GameObject GameOverUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameOverUI.SetActive(false);
    }

    private void OnEnable()
    {
        Healthy.OnPlayerDie += ShowGameOver;
    }

    private void OnDisable()
    {
        Healthy.OnPlayerDie -= ShowGameOver;
    }

    private void ShowGameOver()
    {
        GameOverUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
