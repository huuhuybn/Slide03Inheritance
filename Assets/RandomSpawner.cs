using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawner : MonoBehaviour
{
    
    public GameObject gem;
    public GameObject cherry;
    public GameObject faceBlock;
    
    public float spawnInterval = 1f;
    public float minX = -8f;
    public float maxX = 8f;
    public float spawnY = 6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // gọi hàm  SpawnGem sau 1 giây và tần suất là 1 giây gọi tiếp
        //InvokeRepeating("SpawnGem", 1f, spawnInterval);
    }

    private void Update()
    {
        SpawnGem();
    }

    void SpawnGem()
    {
        float randomX = Random.Range(minX, maxX);
        int ranItem = Random.Range(0, 3);
        Vector3 gemPos = new Vector3(randomX, spawnY, 0);
        
        switch (ranItem)
        {
            case 0:  Instantiate(gem, gemPos, Quaternion.identity); break;
            case 1:  Instantiate(cherry, gemPos, Quaternion.identity); break;
            case 2:  Instantiate(faceBlock, gemPos, Quaternion.identity); break;
        }
     
        // tạo 1 bản clone của gameObject tại vị trí chỉ định 
       
        // gem là gameObject được ánh xạ từ thư mục assets 
        // gemPos là vị trí chỉ định xuất hiện 
        // QUanterion,indentity là tham số chỉ định góc xoay khi gameobject xuất hiện 
        // default 
    }
    
}
