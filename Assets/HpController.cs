using UnityEngine;

public class HpController : MonoBehaviour
{
    public Sprite[] sprites;
    public int maxHP = 6;
    private int index = 5;
    SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   Debug.Log(index);
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = sprites[index];
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log(index);
            index--;
            sr.sprite = sprites[index];
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log(index);
            index++;
            sr.sprite = sprites[index];
        }
    }
}
