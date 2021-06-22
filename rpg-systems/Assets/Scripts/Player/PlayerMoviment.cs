using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector2 moviment;

    [SerializeField]
    private Rigidbody2D rigidbody2D;

    private Animator animator;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        moviment.x = Input.GetAxis("Horizontal");
        moviment.y = Input.GetAxis("Vertical");
       

        animator.SetFloat("Horizontal", moviment.x);
        animator.SetFloat("Vertical", moviment.y);
        animator.SetFloat("speed", moviment.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        

        rigidbody2D.MovePosition(rigidbody2D.position + moviment * speed * Time.fixedDeltaTime);

    }



}
