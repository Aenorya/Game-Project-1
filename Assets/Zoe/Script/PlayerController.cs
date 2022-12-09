using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Physique Player")]
    public Rigidbody2D rb;
    public CapsuleCollider2D playerCollider;

    [Header("Speed Attributes")]
    public float jumpSpeed = 5;
    public float speed = 5;
    
    [Header("Animation")]
    public Animator animator;
    public Animator CamAnimator;

    [Header("Attack Attributes")]
    public float timeAttack;
    public static float damage = 1;

    [Header("PowerUP")]
    public float damagePU;
    public float timePU;
    public float speedPU;
    public SpriteRenderer playerSprite;
    public Sprite newPlayerSprite;

    [Header("Syringe")]
    public int syringeCount = 3;
    public List<GameObject> syringe;
    public int syringeScore;
    public GameObject noSyringe;
    public GameObject noNeedHeal;

    [Header("Other")]
    private bool isGrounded = false;

    private Vector2 direction;
    public PlayerHealth playerHealth;
    public GameObject pauseMenu, collisionAttack;
    public static bool gameIsPaused = false;
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
        playerHealth = GetComponent<PlayerHealth>();
        syringeCount = 3;
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * new Vector3(direction.x, 0, 0); 
    }

    public void Die()
    {
        animator.SetTrigger("Die");
        instance.enabled = false;
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
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    void Paused()
    {
        pauseMenu.SetActive(true);
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
            if (syringeCount > 0)
            {
                if (playerHealth.hp <= 2)
                {
                    playerHealth.HealPlayer();
                    syringeCount--;
                    syringe[syringeCount].SetActive(false);
                    playerSprite.sprite = newPlayerSprite;
                    Invoke("ResetPower", timePU);
                }
                else if (playerHealth.hp == 3)
                {
                    noNeedHeal.SetActive(true);
                    Invoke("TextHealHide", 3);
                }
            }
            else if (syringeCount == 0)
            { 
                noSyringe.SetActive(true);
                Invoke("TextSyringeHide", 3);
            }
        }
    }

    private void TextHealHide()
    {
        noNeedHeal.SetActive(false);
    }
    private void TextSyringeHide()
    {
        noSyringe.SetActive(false);
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
        
        if(syringeCount <= 2)
        {
            syringeCount++;
        }
        else if (syringeCount == 3)
        {
            Score.score = Score.score + syringeScore;
        }
        Debug.Log("Seringue = " + syringeCount);
    }
}
