using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ScoreManager.AddScore(10);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Healthy healthy = GetComponent<Healthy>();
            healthy.TakeDamage(10);
        }
    }
}
