using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("ScoreManager - Awake");
    }

    private void Start()
    {
        Debug.Log("ScoreManager - Start");
    }


    // 1. Khai báo 1 Delegate , nhận vào 1 số nguyên
   public delegate void ScoreAddedHandler(int  score);
   
   // 2. Khai báo Event sự kiện nhận điểm 
   public static event ScoreAddedHandler OnScoreAdded;
    
    // 3, Khai báo hàm để kích hoạt sự kiện 
    public static void AddScore(int score)
    {
        OnScoreAdded?.Invoke(score);
        //GameManager.Instance.GameOver();
    }
    
}
