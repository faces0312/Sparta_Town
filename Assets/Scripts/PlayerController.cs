using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : TownController
{
    //player은 입력을 받아야하므로 클래스가 필요하다
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 aim = value.Get<Vector2>();
        Vector2 wolrdPos = camera.ScreenToWorldPoint(aim);

        aim = (wolrdPos - (Vector2)transform.position.normalized).normalized;
        CallLookEvent(aim);
    }
}
