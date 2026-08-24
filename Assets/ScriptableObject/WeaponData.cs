using UnityEngine;

// Có thể tái sử dụng nhiều lần cho bộ khung 
[CreateAssetMenu(fileName = "WeaponData", menuName = "Weapon/WeaponData")]
public class WeaponData : ScriptableObject
{
    [Header("Thông tin cơ bản")] public string weaponName;
    public string description;
    public Sprite icon;
    public GameObject prefab; // đối tượng gameObject như khẩu súng, dao, vũ khí để nhân vật cầm trên tay 
    public int damage;
    public int attackRange; 
    public float attackSpeed;

    public enum WeaponType
    {
        Dagger,
        Sword,
        Hammer,
        Axe,
        Bow,
    }
    
}
