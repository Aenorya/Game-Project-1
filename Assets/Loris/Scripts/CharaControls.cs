using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharaControls : MonoBehaviour
{
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform Bottom;
    bool isGrounded;
    float mx;
    float jumpCoolDown;
    public Vector3 jump;

    public float moveSpeed = 7f;
    public float jumpHeight = 2.0f;

    public static CharaControls instance;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            //rb.AddForce(jump * jumpHeight, ForceMode.Impulse);
            isGrounded = false;
        }
        mx = Input.GetAxis("Horizontal");
        /*if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }*/

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(mx * moveSpeed, rb.velocity.y);
    }

}
