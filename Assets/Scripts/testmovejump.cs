using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class testmovejump : MonoBehaviour
{
    //���������� �������� ������������
    public float speed = 7f;
    //��������� ���������� ��� �������� ������� ������ � ������������
    private float move;
    private Rigidbody2D _rb;
    public float groundRadius = 0.2f;//������ �������� ������� �����
    public LayerMask groundMask;//���������� ��� ���������� ���� �����
    public Transform groundCheck;//���������� ��� �������� ���������
    public bool isGrounded;
    public float jumpForce = 10f;

    void Start()
    {
        //���������� � �������� ���������� Rigidbody2D
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal") * speed;
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
        }

    }

    void FixedUpdate()
    {
        //������� ��������� ������ �� �����������
        _rb.velocity = new Vector2(move, _rb.velocity.y);
    }
}
