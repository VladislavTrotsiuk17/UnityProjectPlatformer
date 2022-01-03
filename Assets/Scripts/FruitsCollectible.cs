using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FruitsCollectible : MonoBehaviour
{
    [SerializeField, Range(25, 1000)] private int score;
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PickUpFruits();
            
        }
    }

    private void PickUpFruits()
    {
        animator.SetTrigger("PickUp");
        ScoreCollecrot.AddScore(score);

    }
     
    private void frurisDestroy()
    {
        Destroy(gameObject);
    }



}