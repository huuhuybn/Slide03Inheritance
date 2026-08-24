using UnityEngine;

public class WeaponController : MonoBehaviour
{
    
    public WeaponData currentWeapon;
    public Transform weaponHolder;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject weapon  = Instantiate(currentWeapon.prefab,weaponHolder.position,Quaternion.identity);
    }

    void Attack()
    {
        // Khi tan cong thi lam gi 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
