using UnityEngine;

public class FrogController : MonoBehaviour
{
    public float jumpForceX = 10f;
    public float jumpForceY= 10f;
    private Rigidbody2D _rigidbody2D;
    Animator anim;
    bool isGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.linearVelocity = new Vector2(jumpForceX, jumpForceY);
            isGrounded = false;
            anim.SetInteger("status", 1);
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetInteger("status", 0);
        }}
    
}
