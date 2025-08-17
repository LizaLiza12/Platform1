using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private float speed;
    [SerializeField] private float Jupmoffser;

    [SerializeField] private bool isground = false;

    private Rigidbody2D rb;
    private Animator charteranim;
    [SerializeField] private Transform groundCollider;
    [SerializeField] private LayerMask groundMack;
   private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        charteranim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        Vector3 overPosition= groundCollider.position;
        isground = Physics2D.OverlapCircle(overPosition, Jupmoffser, groundMack);
    }
    public void Move(float direction, bool Jupmpressed)
    {
        charteranim.SetBool("isrun", true);
        if (Jupmpressed)
        Jump();
        if (direction != 0)
         HorizontalMovement(direction);
    }
    public void Jump()
    {
        if(isground)
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
    private void HorizontalMovement(float direction)
    {
        charteranim.SetBool("isrun",false);
        rb.velocity = new Vector2(direction * speed,rb.velocity.y);
    }
}
