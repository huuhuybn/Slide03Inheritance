using System;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    [Serializable]
    public class ItemData
    {
        public string itemId;
        public GameObject prefab;
    }

    public class AdvancedItemFactory : MonoBehaviour
    {
        public string name;
        [Header("Item Prefabs")]
        public List<ItemData> items; // Bổ sung danh sách các Item prefab trong thư mục assets
        // Khai báo Dictionary để tìm kiếm 
        Dictionary<string, GameObject> itemPrefabs = new Dictionary<string, GameObject>();

        private void Awake(){
            // khi game chạy thì nạp danh sách items vào Dictionary 
            foreach (ItemData item in items)
            {
                itemPrefabs.Add(item.itemId, item.prefab);
            }
        }

        public GameObject CreateItem(string itemId, Vector3 spawnPosition)
        {
            // lấy ra prefab có trong Dictionary nếu có thông qua itemId 
            if (itemPrefabs.TryGetValue(itemId, out GameObject newItem))
            {
                return Instantiate(newItem, spawnPosition, Quaternion.identity);
            }
            else
            {
                return null;
            }
        }
        
        
    }
}