using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Physique Player")]
    public Rigidbody2D rb;
    public CapsuleCollider2D playerCollider;

    private bool isGrounded = false;

    [Header("Speed Attributes")]
    public float jumpSpeed = 5;
    public float speed = 5;
    public float speedPU;
    private Vector2 direction;

    public GameObject menuPanel, collisionAttack;
    public static bool gameIsPaused = false;

    [Header("Animation")]
    public Animator animator;
    public Animator CamAnimator;

    [Header("Attack Attributes")]
    public float timeAttack;
    public static float damage = 1;
    public float damagePU;
    public float timePU;

    [Header("Syringe")]
    public int syringeCount = 0;

    public bool Changed = false;

    public PlayerHealth playerHealth;

    public static PlayerController instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerMovement dans la scène");
            return;
        }

        instance = this;
    }

    private void Start()
    {
        Changed = false;
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * new Vector3(direction.x, 0, 0); 
    }

    public void Die()
    {
        instance.enabled = false;
        animator.SetTrigger("Die");
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.velocity = Vector3.zero;
        playerCollider.enabled = false;
        GameOverManager.instance.OnPlayerDeath();
        Debug.Log("Player eliminated");
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed)
        {   
            Debug.Log("La touche action à été activé");

        } else if (context.canceled)
        {
            Debug.Log("La touche action a été relaché");
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
        GetComponent<SpriteRenderer>().flipX = (direction.x < 0);

        if (direction.x < 0)
        {
            CamAnimator.SetBool("CamSlide", true);
        }
        else if (direction.x > 0)
        {
            CamAnimator.SetBool("CamSlide", false);
        }
    }

    public void Change(InputAction.CallbackContext contexte)
    {
        if (contexte.performed)
        {
            Changed = true;
            animator.SetBool("Change", true);
        }
    }

    public void Attack(InputAction.CallbackContext contexte)
    {
        if (contexte.performed)
        {
            collisionAttack.SetActive(true);
            Invoke("ResetAttack", timeAttack);
        } 
        /*else if (contexte.canceled)
        {
            collisionAttack.SetActive(false);

        }*/
    }

    private void ResetAttack()
    {
        collisionAttack.SetActive(false);
    }

    public void PauseMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    void Resume()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    void Paused()
    {
        menuPanel.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    public void UseSyringe(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            speed = speed * speedPU;
            damage = damage * damagePU;
            Invoke("ResetPower", timePU);
        }
    }

    private void ResetPower()
    {
        speed = speed / speedPU;
        damage = damage / damagePU;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        if (collision.gameObject.CompareTag("PickableObject"))
        {
            PickUpSyringe();
            Debug.Log("Seringue");
            Destroy(collision.gameObject);
        }
    }

    public void PickUpSyringe()
    {
        syringeCount++;
        Debug.Log("Seringue = " + syringeCount);
    }
}
