using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestOnePlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpHeight = 5;
    public float walkSpeed = 5;
    public InputAction playerControls;

    private Vector2 moveDirection;

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Update()
    {
        moveDirection = playerControls.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * walkSpeed, moveDirection.y * walkSpeed);
    }
}
