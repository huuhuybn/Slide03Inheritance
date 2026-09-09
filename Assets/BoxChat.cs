using NUnit.Framework;
using TMPro;
using UnityEngine;

public class BoxChat : MonoBehaviour
{

    public string[] chats;
    public TextMeshProUGUI chatText;
    private int index = 0;
    
    public void SkipText()
    {
        if (index >= chats.Length)
        {
            // chuyen man hinh hoac tat chatbox
        }
        index++;
        chatText.text = chats[index];
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chatText.text = chats[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
