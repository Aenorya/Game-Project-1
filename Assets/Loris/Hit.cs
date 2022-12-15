using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    bool hasHit = false;

    private void OnEnable()
    {
        hasHit = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player") && !hasHit)
        {
            Debug.Log("HIT");
            collision.transform.GetComponentInParent<PlayerHealth>().Hurt();
            hasHit = true;
        }
    }
}
