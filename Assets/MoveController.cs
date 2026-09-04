using UnityEngine;

public class MoveController : MonoBehaviour
{
    private int moveDirection = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void PointerDownLeft()
    {
        moveDirection = -1;
    }
    
    public void PointerDownRight()
    {
        moveDirection = 1;
    }
    
    public void PointerUp()
    {
        moveDirection = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(2f * moveDirection * Time.deltaTime,0,0));
    }
}
