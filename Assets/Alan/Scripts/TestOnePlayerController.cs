using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestOnePlayerController : MonoBehaviour
{
    public Animator animator;

    public void Punch()
    {
        animator.SetTrigger("Punch");
    }
}
