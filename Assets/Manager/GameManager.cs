using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // khai báo nó ở trạng thái 1 biến tĩnh 
    public static GameManager Instance { get; set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   // Kiểm tra xem đã khởi tạo GameManager trước đó chưa, nếu có rồi thì hủy đi, tránh tạo thừa 
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            // Khong huy GameManager khi chuyển scene 
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
    }

    public void Victory()
    {
        Debug.Log("Victory");
    }

    public void RestartLevel()
    {
        // nạp lại Scene hiện tại 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
