using System;
using Manager;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public int direction = 1;

  

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right *  direction * speed * Time.deltaTime);
    }
   
    private void OnEnable()
    {
        Invoke("Deactivate", 3f);
    }

    public void Deactivate()
    {
        BulletPool.instance.ReturnBullet(gameObject);
    }
}
