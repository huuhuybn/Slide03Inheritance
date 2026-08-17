using System;
using Component.Player;
using Interface;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private IPlayerState currentPlayerState;
    public PlayerIdleState idleState = new PlayerIdleState();
    public PlayerRunState runState = new PlayerRunState();
    public PlayerJumpState jumpState = new PlayerJumpState();
    public float jumpForce = 10f;
    public Rigidbody2D rigidBody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        ChangeState(idleState);
    }

    public void ChangeState(IPlayerState newPlayerState)
    {
        // gọi hàm exit của state cũ nếu có 
        if (currentPlayerState != null)
        {
            currentPlayerState.ExitState(this);
        }
        currentPlayerState = newPlayerState; 
        // goi ham bắt đầu state mới 
        currentPlayerState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPlayerState != null)
        {
            currentPlayerState.UpdateState(this);
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            ScoreManager.AddScore(10);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Healthy healthy = GetComponent<Healthy>();
            healthy.TakeDamage(10);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
     

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter2D");
        Debug.Log(other.gameObject.name);
        // Cham 1 vao gameobject co tag la Block
        if (other.gameObject.tag.Equals("Block"))
        {
            // Bien mat block
            Destroy(other.gameObject);
        }
        IPickable pickable = other.gameObject.GetComponent<IPickable>();
        if (pickable != null)
        {
            pickable.OnPickedUp(this);
        }
        else
        {
            Debug.Log("Ko co pickable");
        }
        /*if (other.gameObject.tag.Equals("Gem"))
        {
            Destroy(other.gameObject);
            // cong diem ..
        }

        if (other.gameObject.tag.Equals("Fruit"))
        {
            Destroy(other.gameObject);
            // Cong diem
        }*/
        
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("OnCollisionStay2D");
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("OnCollisionExit2D");
    }
}
