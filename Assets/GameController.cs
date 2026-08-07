using System.Collections.Generic;
using Interface;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // lấy ra toàn bộ GameObject có ITransform và gọi Transform 
            var allEnemies = FindObjectsByType<MonoBehaviour>();
            List<ITransform> trans = new List<ITransform>();
            foreach (var obj in allEnemies)
            {
                ITransform iTran = obj.GetComponent<ITransform>();
                trans.Add(iTran);
            }
            // Gọi toàn bộ hàm Transform 
            foreach (var iTran in trans)
            {
                iTran.Transform();
            }
        }
    }
}
