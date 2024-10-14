using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animator : MonoBehaviour
{
    protected Animator animator;
    protected PlayerController controller;
    private readonly float magnituteThreshold = 0.5f;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<PlayerController>();
    }

    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool("Is_Run", obj.magnitude > magnituteThreshold);
    }
}
