using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTrigger : MonoBehaviour
{
    public Rigidbody2D rb;
    public float grav;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.gravityScale = grav;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        rb.gravityScale = 1;
    }
}
