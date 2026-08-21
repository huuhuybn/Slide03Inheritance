using System;
using Manager;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawner : MonoBehaviour
{
    
    public AdvancedItemFactory itemFactory;
    
    public float spawnInterval = 1f;
    public float minX = -8f;
    public float maxX = 8f;
    public float spawnY = 6f;
    
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
            case 0:  itemFactory.CreateItem("Gem", gemPos); break;
            case 1:  itemFactory.CreateItem("Cherry", gemPos); break;
            case 2:  itemFactory.CreateItem("Trap", gemPos); break;
        }
     
        // tạo 1 bản clone của gameObject tại vị trí chỉ định 
       
        // gem là gameObject được ánh xạ từ thư mục assets 
        // gemPos là vị trí chỉ định xuất hiện 
        // QUanterion,indentity là tham số chỉ định góc xoay khi gameobject xuất hiện 
        // default 
    }
    
}
