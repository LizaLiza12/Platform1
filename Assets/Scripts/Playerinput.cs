using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMove))]

public class Playerinput : MonoBehaviour
{
    private PlayerMove PlayerMove;
    private void Awake()
    {
        PlayerMove = GetComponent<PlayerMove>();
    }
    private void Update()
    {
        float horizontalDirectional = Input.GetAxisRaw(stringaxis.horiAxis);
        bool isbuttonPressed = Input.GetButtonDown(stringaxis.Jump);
        PlayerMove.Move(horizontalDirectional,isbuttonPressed);
    }
}
