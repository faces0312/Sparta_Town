using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownMove : MonoBehaviour
{
    private TownController movementController;
    private Rigidbody2D movementRigidbody;

    //이동방향
    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // 같은 게임오브젝트의 TopDownController, Rigidbody를 가져올 것 
        movementController = GetComponent<TownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        // OnMoveEvent에 Move를 호출하라고 등록함
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // 물리 업데이트에서 움직임 적용
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // 이동방향만 정해두고 실제로 움직이지는 않음.
        // 움직이는 것은 물리 업데이트에서 진행(rigidbody가 물리니까)
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}
