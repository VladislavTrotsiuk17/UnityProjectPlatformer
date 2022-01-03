using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CherectersController : MonoBehaviour
{
    // ====== MOVEMENT, JUMP ======   
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private float jumpForce = 7.0f;
    private int jumpCount = 0;
    private int maxJumpCount = 2;
    
    private Rigidbody2D rb;
    private Vector2 moveVector;


    // ====== GROUND CHECK ======
    private bool onGround;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private float checkRadius = 0.5f;
    [SerializeField] private LayerMask Ground;


    // ====== ANIMATION ======
    private Animator animator;    
    private bool faceRight = true;

    private Controls inputs;

    private void Awake()
    {
        inputs = new Controls();
        inputs.MainCharacters.Jump.performed += ContextMenu => Jump();
        //inputs.MainCharacters.PlatformJump.performed += ContextMenu => PlatformJump();       

    }
    private void OnEnable()
    {
        inputs.Enable();
    }

    private void OnDisable()
    {
        inputs.Disable();
    }

    void Start()
    {
        // ====== MOVEMENT ======
        rb = GetComponent<Rigidbody2D>();
        // ====== ANIMATION ======
        animator = GetComponent<Animator>();

    }

    private void FixedUpdate()
    {
        Move();               
        CheckingGround();
        
    }

    private void Move()
    {
        moveVector = inputs.MainCharacters.Move.ReadValue<Vector2>();

        animator.SetFloat("MoveX", Mathf.Abs(moveVector.x));        

        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);        
        Flip();

    }

    private void Flip()
    {
        if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;

        }

    }

    private void Jump()
    {              
        if (onGround || (++jumpCount < maxJumpCount))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
           
            if (++jumpCount == maxJumpCount)
            {
                animator.SetTrigger("DoubleJump");               
                
            }
           
        }

        if (onGround)
        {
            jumpCount = 0;

        }
    }
    
    private void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
        animator.SetBool("OnGround", onGround);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
            
        }

    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("Death");
        
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
    //private void PlatformJump()
    //{        
    //    Physics2D.IgnoreLayerCollision(7, 8, true);
    //    Invoke("IgnoreLayerOff", 0.3f);

    //}

    //private void IgnoreLayerOff()
    //{
    //    Physics2D.IgnoreLayerCollision(7, 8, false);

    //}


}
