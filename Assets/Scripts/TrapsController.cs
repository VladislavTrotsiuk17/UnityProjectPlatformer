using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrapsController : MonoBehaviour
{
    [SerializeField] private bool moveOnOff = true;
    [SerializeField] private float speed;
    [SerializeField] private int startingPoint;
    [SerializeField] private Transform[] points;

    private int i;

    private void Start()
    {
        if (moveOnOff)
        {
            transform.position = points[startingPoint].position;
        }
    }

    
    private void FixedUpdate()
    {
        if (moveOnOff)
        {
            Move();
        }
    }


    private void Move()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Equals("Player"))
        {
            if(transform.position.y < collision.transform.position.y -0.1f)            
                collision.transform.SetParent(transform);
           
        }
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            collision.transform.SetParent(null);
        }
    }

}
