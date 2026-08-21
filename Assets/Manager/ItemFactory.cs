using UnityEngine;

namespace Manager
{
    public enum ItemType
    {
        Gem, Cherry, Trap
    }
    public class ItemFactory : MonoBehaviour
    {
        [Header("Item Prefabs")] // đặt tên cho menu ở Inspector 
        public GameObject gemPrefab;
        public GameObject cherryPrefab;
        public GameObject trapPrefab;

        public GameObject CreateItem(ItemType itemType, Vector3 spawnPosition)
        {
            GameObject newItem = null;
            switch (itemType)
            {
                case ItemType.Gem:
                    newItem = Instantiate(gemPrefab, spawnPosition, Quaternion.identity);
                    break;
                case  ItemType.Cherry: 
                    newItem = Instantiate(cherryPrefab, spawnPosition, Quaternion.identity);
                    break;
                case  ItemType.Trap: 
                    newItem = Instantiate(trapPrefab, spawnPosition, Quaternion.identity);
                    break;
                default:
                    Debug.Log(itemType);
                    break;
            }
            return newItem;
        }
        
    }
}