using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private float horizontal;
    private float vertical;
    private float speed = 4.0f;
    public Rigidbody2D rb;
    public CapsuleCollider2D playerCollider;

    public Animator animator;

    public bool turnedLeft;

    public static PlayerScript instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerHealth dans la scène");
            return;
        }

        instance = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        turnedLeft = false;
        
        if (horizontal > 0)
        {
            GetComponent<Animator>().Play("RunR");
        }
        else if (horizontal < 0)
        {
            GetComponent<Animator>().Play("RunL");
            turnedLeft = true;
        }
        else if (horizontal == 0)
        {
            GetComponent<Animator>().Play("Idle");
        }
        
        /*if (Input.GetKeyDown(KeyCode.C) && !turnedLeft)
        {
            animator.SetTrigger("Dodge");

        }else if (Input.GetKeyDown(KeyCode.C) && turnedLeft)
        {
            Vector3 flipped = transform.localScale;
            flipped.z *= -1f;
            transform.localScale = flipped;
            //transform.Rotate(0f, 180f, 0f);
            animator.SetTrigger("Dodge");
        }
        animator.ResetTrigger("Dodge");*/

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }*/
    }
}
