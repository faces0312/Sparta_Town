using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer character1Renderer;
    [SerializeField] private SpriteRenderer character2Renderer;

    private TownController controller;

    private void Awake()
    {
        controller = GetComponent<TownController>();
    }

    void Start()
    {
        // 마우스의 위치가 들어오는 OnLookEvent에 등록하는 것
        controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 direction)
    {
        RotateZ(direction);
    }

    private void RotateZ(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        character1Renderer.flipX = Mathf.Abs(rotZ) > 90f;
        character2Renderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
