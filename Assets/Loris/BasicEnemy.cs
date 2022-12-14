using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public int MaxHealth = 1;
    int currentHealth;
    public Animator animator;

    //public static BasicEnemy instance;

    private void Awake()
    {
        //if (instance != null)
        //{
        //    Debug.LogWarning("Il y a plus d'une instance de PlayerMovement dans la scène");
        //    return;
        //}
        //instance = this;
    }

    void Start()
    {
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;


        if (currentHealth <= 0)
        {
            GetComponent<Enemy_behaviour>().enabled = false;
            animator.Play("Dead");
            Invoke("Die", 0.1f);
        }
    }

    public void Die()
    {
        //GetComponent<Enemy_behaviour>().moveSpeed = 0; 
        GetComponent<Droper>().InstantiateLoot(transform.position);
        Destroy(gameObject);
    }
}
