using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private bool platformFall = false;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (platformFall)
        {
            Invoke("PlatformFall", 1f);
            Destroy(gameObject, 2f);
        }

    }

    private void PlatformFall()
    {
        rb.isKinematic = false;
    }
}
