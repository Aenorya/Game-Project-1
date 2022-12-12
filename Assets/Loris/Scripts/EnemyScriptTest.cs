using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptTest : MonoBehaviour
{
    private float range;
    private Transform target;
    public float minDistance = 5.0f;
    private bool targetCollision = false;
    private float speed = 2.0f;
    private float thrust = 1.5f;
    public static float health = 5;
    private int hitStrength = 1;

    private CurrentSceneManager gameManager;

    private bool isDead = false;

    //public PlayerHealth playerHealth;

    public static EnemyScriptTest instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de EnemyScript dans la scène");
            return;
        }
        instance = this;
    }

    void Start()
    {
        gameManager = GetComponent<CurrentSceneManager>();
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
        range = Vector2.Distance(transform.position, target.position);
        if (range < minDistance && !isDead)
        {
            if (!targetCollision)
            {
                // Get the position of the player
                transform.LookAt(target.position);

                // Correct the rotation
                transform.Rotate(new Vector3(0, -90, 0), Space.Self);
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }
        transform.rotation = Quaternion.identity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Vector3 difference = transform.position - collision.transform.position;
            if (difference.x < 0) GetComponent<Rigidbody2D>().AddForce(transform.right * thrust, ForceMode2D.Impulse);
            if (difference.x > 0) GetComponent<Rigidbody2D>().AddForce(-transform.right * thrust, ForceMode2D.Impulse);
            Invoke("FalseCollision", 0.5f);
            PlayerHealth.instance.Hurt();
        }
    }

    void FalseCollision()
    {
        targetCollision = false;
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health == 0)
        {
            isDead = true;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            //GetComponent<Collider2D>().enabled = false;
            Invoke("EnemyDeath", 0.5f);
        }
        
    }

    void EnemyDeath()
    {
        Vector3 dropPos = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        GetComponent<InventoryFinalVersion>().InstantiateLoot(dropPos);
        //gameManager.SetMobCount(-1);
        Invoke("Destroy", 0.1f);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public int GetHitStrength()
    {
        return hitStrength;
    }
}

