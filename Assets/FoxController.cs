using UnityEngine;

public class FoxController : MonoBehaviour
{   
    // Component dieu khien animation 
    private Animator anim;
    private Rigidbody2D rb;
    // thong so di chuyen
    [Header("Thong so di chuyen")]
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private float horizontalInput;
    
    public Transform groundCheck; // vi tri duoi chan nhan vat 
    LayerMask groundLayer; // lớp gameobject coi là mặt đất - gần giống tag nhưng rộng hơn 
    bool isGrounded; // trang thai nhan vat co cham dat khong 
    
    bool isCrouching = false;
    private bool isRolling = false;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        // kiểm tra nhân vật có đang chạm đất hay ko, bằng cách tạo 1 hình tròn nhỏ 
        if (groundCheck != null)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        // lật mặt nhân vật cho đúng hướng 
        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !isRolling && !isCrouching)
        {
            Debug.Log("jumpForce enter");
            rb.linearVelocity = new  Vector2(rb.linearVelocity.x, jumpForce);
        }
        // Cúi xuống 
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.DownArrow) && isGrounded)
        {
            isCrouching = true;
        }else if (Input.GetKeyUp(KeyCode.C) || Input.GetKeyUp(KeyCode.DownArrow) && isGrounded)
        {
            isCrouching = false;
        }

        if (Input.GetKeyDown(KeyCode.V) && !isRolling && isGrounded)
        {
            anim.SetTrigger("Roll");
            isRolling = true;
        }

        UpdateAnimation();
    }
    void UpdateAnimation()
    {
       anim.SetFloat("Speed", Mathf.Abs(horizontalInput));
       anim.SetFloat("VelocityY", rb.linearVelocity.y);
       anim.SetBool("IsGrounded", isGrounded);
       anim.SetBool("IsCrouching", isCrouching);
    }

    public void TakeDamage()
    {
        anim.SetTrigger("Hurt");
    }

    public void OnRollComplete()
    {
        isRolling = false;
    }
    
    // 50 lần / giây. xử lý các  tương tác vật lý . độc lập với fps 
    void FixedUpdate()
    {
        if (isCrouching || isRolling)
        {
            rb.linearVelocity = new  Vector2(0, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new  Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
        }
    }
}
