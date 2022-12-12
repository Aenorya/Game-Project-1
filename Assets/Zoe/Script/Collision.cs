using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            EnemyScriptTest.instance.TakeDamage(PlayerController.damage);
            //Debug.Log(EnemyScriptTest.health);
        }
        if (collision.gameObject.CompareTag("ReBox"))
        {
            BoxDrop.instance.HitBox(PlayerController.damage);
        }
    }
}
