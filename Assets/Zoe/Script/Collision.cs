using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            EnemyScriptTest.instance.TakeDamage(PlayerController.damage);
            Debug.Log(EnemyScriptTest.health);
        }
    }
}
