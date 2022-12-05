using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTrigger : MonoBehaviour
{
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb.gravityScale = -1;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        rb.gravityScale = 1;
    }
}
