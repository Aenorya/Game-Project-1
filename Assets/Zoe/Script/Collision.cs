using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            collision.transform.GetComponent<BoxDrop>().HitBox(PlayerController.damage);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.transform.GetComponent<BasicEnemy>().TakeDamage(PlayerController.damage);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
