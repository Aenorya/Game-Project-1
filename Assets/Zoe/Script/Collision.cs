using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        /*if(collision.gameObject.CompareTag("Enemy"))
        {
            EnemyScriptTest.instance.TakeDamage(PlayerController.damage);
            //Debug.Log(EnemyScriptTest.health);
        }*/

        if (collision.gameObject.CompareTag("ReBox"))
        {
            BoxDrop.instance.HitBox(PlayerController.damage);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            BasicEnemy.instance.TakeDamage(PlayerController.damage);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
