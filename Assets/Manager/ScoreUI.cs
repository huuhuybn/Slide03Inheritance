using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    Text scoreText;
    int currentScore = 0;

    private void Awake()
    {
        
        Debug.Log("ScoreUI - Awake");
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        scoreText.text = "Score: " + currentScore;
    }

    private void Start()
    {
        Debug.Log("ScoreUI - Start");
    }

    private void OnEnable()
    {
        // dang ki su kien OnScoreAdded
        ScoreManager.OnScoreAdded += UpdateScoreText;
    }

    private void OnDisable()
    {
        ScoreManager.OnScoreAdded -= UpdateScoreText;
    }

    void UpdateScoreText(int score)
    {
        currentScore += score;
        scoreText.text = "Score: " + currentScore;
    }
    
    
    
    
}
