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
            StartCoroutine(Die());
        }
    }

    public IEnumerator Die()
    {
        //GetComponent<Enemy_behaviour>().moveSpeed = 0; 
        GetComponent<Enemy_behaviour>().enabled = false;
        animator.Play("Dead");
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
