using System;
using Component.Player;
using Interface;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
    }
    
    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        if (moveInput != 0)
        {
            transform.Translate(Vector3.right * moveInput * Time.deltaTime);
        }
        else
        { 
            // trang thai Idle 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Jump
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Attack
        }
        // viet 1 loat cac su kien logic xu ly khi nhan vat thay doi trang thai 
        
        
        
    }
}
