using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public int MaxHealth = 1;
    int currentHealth;
    public Animator animator;

    void Start()
    {
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            CountEnemy.instance.numberEnemy = CountEnemy.instance.numberEnemy - 1;
            animator.Play("Dead");
            Invoke("Die", 0.1f);
        }
    }

    public void Die()
    {
        GetComponent<Droper>().InstantiateLoot(transform.position);
        Destroy(gameObject);
    }
}
