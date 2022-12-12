using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public int MaxHealth = 10;
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
            StartCoroutine(Die());
        }
    }

    public IEnumerator Die()
    {
        //GetComponent<Enemy_behaviour>().moveSpeed = 0; 
        GetComponent<Enemy_behaviour>().enabled = false;
        animator.Play("Dead");
        yield return new WaitForSeconds(2.30f);
        Destroy(gameObject);
    }
}
