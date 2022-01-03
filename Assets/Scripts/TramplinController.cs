using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramplinController : MonoBehaviour
{
    [SerializeField] private float jampForce = 10f;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Equals("Player"))
        {
            stayPlatform(collision);
        }

    }
    private void stayPlatform(Collision2D collision)
    {        
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jampForce, ForceMode2D.Impulse);
            animator.SetTrigger("TramplinJump");
        
    }
}
