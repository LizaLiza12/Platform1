using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class testmovejump : MonoBehaviour
{
    //переменная скорости передвижения
    public float speed = 7f;
    //приватная переменная для хранения входных данных о передвижении
    private float move;
    private Rigidbody2D _rb;
    public float groundRadius = 0.2f;//Радиус проверки наличия земли
    public LayerMask groundMask;//Переменная для назначение слоя земли
    public Transform groundCheck;//Переменная для передачи координат
    public bool isGrounded;
    public float jumpForce = 10f;

    void Start()
    {
        //Добавление в сценарий компонента Rigidbody2D
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
        //Придаем ускорение игроку по горизонтали
        _rb.velocity = new Vector2(move, _rb.velocity.y);
    }
}
