using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            Debug.Log("HIT");
            collision.transform.GetComponentInParent<PlayerHealth>().Hurt();
        }
    }
}
