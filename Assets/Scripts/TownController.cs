using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        //OnMoveEvent���� ���ϸ� �̺�Ʈ ȣ��
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
