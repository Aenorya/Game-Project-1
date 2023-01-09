using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [Header("Physics Player")]
    public Rigidbody2D rb;
    public CapsuleCollider2D playerCollider;

    [Header("PopMess")]
    public TextMeshProUGUI popUpMessage;
    public GameObject goMessage;
    public float timeTextHide;

    [Header("Speed Attributes")]
    public float jumpSpeed = 5;
    public float speed = 5;
    public float speedLess;

    [Header("Animation")]
    public Animator animator;
    public Animator CamAnimator;
    public Animator openDoor;

    [Header("Attack Attributes")]
    public float timeAttack;
    public static int damage = 1;
    public float timeJump;
    public float timeDeath;

    [Header("Syringe")]
    public int syringeCount = 3;
    public List<GameObject> syringe;
    public int syringeScore;
    public GameObject noSyringe;
    public GameObject noNeedHeal;

    [Header("Other")]
    private bool isGrounded = false;
    public string textInteract;

    private Vector2 direction;
    public PlayerHealth playerHealth;
    public GameObject pauseMenu, collisionAttack, breakFloor;
    public static bool gameIsPaused = false;

    public bool inContact = false;
    public bool bombButtonIsPressed = false;
    public bool attackGround = false;
    public bool doorButtonIsPressed = false;

    public GameObject poing;
    public RawImage cameraDoor;

    public ButtonRespawnBox respawnButtonBox;

    public static PlayerController instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerMovement dans la sc�ne");
            return;
        }
        instance = this;
    }

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
        syringeCount = 3;
        inContact = false;
        bombButtonIsPressed = false;
        attackGround = false;
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
        Invoke("DeathPlayer", timeDeath);
        Debug.Log("Player eliminated");
    }

    public void DeathPlayer()
    {
        //GameOverManager.instance.OnPlayerDeath();
        SceneManager.LoadScene("Main_Menu");
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && inContact)
        {
            respawnButtonBox.OnInteraction();

            Debug.Log("La touche action � �t� activ�");
        }
        else if (context.performed && bombButtonIsPressed)
        {
            Timer.instance.BombButtonTimer = true;

            Debug.Log("wowie it works there is no boom");
        }
        else if (context.performed && doorButtonIsPressed)
        {
            Debug.Log("Boutooooooooon");
            openDoor.enabled = true;
            cameraDoor.enabled = true;
            Invoke("ResetCameraDoor", 1f); //Modifier par rapport au temps de l'anim
        }
        else if (context.canceled)
        {
            inContact = false;

            Debug.Log("La touche action a �t� relach�");
        }
    }

    void ResetCameraDoor()
    {
        cameraDoor.enabled = false;
    }

    public void Move(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();

        if (direction.x < 0)
        {
            poing.transform.localPosition = new Vector2(-1.72f, 0.72f);
            CamAnimator.SetBool("CamSlide", true);
            animator.SetBool("Walk", true);
            GetComponent<SpriteRenderer>().flipX = true;
        }

        else if (direction.x > 0)
        {
            poing.transform.localPosition = new Vector2(1.72f, 0.72f);
            CamAnimator.SetBool("CamSlide", false);
            animator.SetBool("Walk", true);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
    public void Attack(InputAction.CallbackContext contexte)
    {
        if (contexte.performed)
        {
            animator.SetBool("IsAttacking", true);
            collisionAttack.SetActive(true);
            speed = speed - speedLess;
        }
        else if (contexte.canceled)
        {
            animator.SetBool("IsAttacking", false);
            collisionAttack.SetActive(false);
            speed = speed + speedLess;
            attackGround = false;
        }
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

    public void Resume()
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
            animator.SetBool("Jump", true);

           if (attackGround)
           {
               Invoke("BreakFloor", timeJump);
           }
        }
    }

    void BreakFloor()
    {
        Destroy(breakFloor);
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
                }
                else if (playerHealth.hp == 3)
                {
                    noNeedHeal.SetActive(true);
                    Invoke("TextHealHide", timeTextHide);
                }
            }
            else if (syringeCount == 0)
            {
                noSyringe.SetActive(true);
                Invoke("TextSyringeHide", timeTextHide);
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

    public void PickUpSyringe()
    {

        if (syringeCount <= 2)
        {

            syringeCount++;
            syringe[syringeCount - 1].SetActive(true);
        }
        else if (syringeCount == 3)
        {
            Score.score = Score.score + syringeScore;
        }
        Debug.Log("Seringue = " + syringeCount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BreakableFloor"))
        {
            attackGround = true;
        }

        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("ReBox") || collision.gameObject.CompareTag("BreakableFloor"))
        {
            isGrounded = true;
            animator.SetBool("Jump", false);
        }

        if (collision.gameObject.CompareTag("PickableObject"))
        {
            PickUpSyringe();
            Debug.Log("Seringue");
            Destroy(collision.gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ButtonDoor")
        {
            goMessage.SetActive(true);
            popUpMessage.text = (textInteract);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CollisionZone")
        {
            goMessage.SetActive(false);
        }
    }
}
